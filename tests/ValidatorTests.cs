using System;
using System.IO;
using oai_pmh_invalid_char_locator;
using Xunit;

namespace tests {
    public class ValidatorTests {
        [Fact]
        public void SampleFileIsBroken() {
            var src = File.ReadAllText("sample.xml");
            Validator.Validate(src);
        }
    }
}
