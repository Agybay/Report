using DevExpress.XtraPrinting.Native;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using OpenCity.Domain.Context;
using OpenCity.Domain.Entities;
using OpenCity.Report.Contracts;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCity.Report.Infrastructure.Impl.BackgroundJobs {
    public class ProcessOutboxMessagesJob : IJob {
        private readonly ApplicationContext _context;
        private readonly IBus _bus;

        public ProcessOutboxMessagesJob(ApplicationContext context, 
            IBus bus) {
            _context = context;
            _bus = bus;
        }

        public async Task Execute(IJobExecutionContext context) {
           var messages = await _context.Set<OutboxMessage>()
                .Where(x => x.Processed == null)
                .Take(20)
                .ToListAsync(context.CancellationToken);

            foreach (var message in messages) {
                var response = new ResponseDocument {
                    ApplicationId = message.ApplicationId,
                    CorrelationId = Guid.NewGuid(),
                    DocumentId = message.DocumentId,
                    MimeType = message.DocumentMimeType,
                    ReportState = message.CoverLetterCondition,
                    ReportType = message.ReportType
                };

                await _bus.Publish(response, context.CancellationToken);
                message.Processed = DateTime.Now;
            }

            await _context.SaveChangesAsync();
        }
    }
}
