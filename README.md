# Introduction 
This was a quick and dirty project I whipped up to parse the log files extracted from devops using powershell. 

# Getting Started
PowerShell
``` PowerShell
# run these one at a time
az extension add --name azure-devops
az login
 
# Then you can do fun stuff like this
az repos pr list --organization  https://dev.azure.com/{your org} --project {your project} --repository {your repo name} --status all | Set-Content -Path "{local path to output to}.json"
```
[Learn about Azure DevOps command line interface extension - Azure DevOps | Microsoft Learn](https://learn.microsoft.com/en-us/azure/devops/cli/?view=azure-devops)

Once you have those files saved locally, you'll need to parse them.
Clone and build this repo.

Publish it locally then using your command line, {path}>DavesJsonParser.exe "{json file, full path}"
ex. I:\temp>DavesJsonParser.exe "C:/1/temp/{local path}.json"

This will output the results to the screen
