namespace OpenCity.Report.Application.Extensions {
    public static class TextsHelper {
        public static string FullNameToAbbreviated(this string fullName) {
            if(string.IsNullOrEmpty(fullName)) {
                return string.Empty;
            }
            var tokens = fullName.Split(new[] { ' ', '\'', '-', '`' }, StringSplitOptions.RemoveEmptyEntries);
            tokens = new[] { tokens[0] }.Concat(tokens.Skip(1).Select(ToAbbr)).ToArray();
            return string.Join(" ", tokens);
        }
        private static string ToAbbr(this string token) {
            if(string.IsNullOrEmpty(token)) {
                return string.Empty;
            }
            var firstLetter = token.Substring(0, 1);
            return $"{firstLetter.ToUpper()}.";
        }
    }
}
