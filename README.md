# OAI-PMH Invalid Char Validator

This is a small tool written to check which record that has invalid chars (usually 0x1E and 0x1F).

Clone the repository make sure to have netcore 3.0 sdk installed and run it as follows.

> cd oai-pmh-invalid-char-locator/src/oai-pmh-invalid-char-locator
>
> dotnet run -- http://oai.example.com/OAI/?verb=ListRecords&...
