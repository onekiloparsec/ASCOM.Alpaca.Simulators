dotnet publish -c Release -r win-x64 --self-contained true /p:PublishTrimmed=true /p:PublishReadyToRun=true /p:PublishReadyToRunShowWarnings=true -p:PublishSingleFile=true -o ./bin/ascom.alpaca.simulators.windows-x64
dotnet publish -c Release -r win-x86 --self-contained true /p:PublishTrimmed=true /p:PublishReadyToRun=true /p:PublishReadyToRunShowWarnings=true -p:PublishSingleFile=true -o ./bin/ascom.alpaca.simulators.windows-x86