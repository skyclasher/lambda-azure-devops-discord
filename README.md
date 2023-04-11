# Azure Devops Discord AWS Lambda Webhook
A simple AWS lambda function that takes a Azure Devops webhook payload, creates a Discord-compatible webhook payload, and executes the appropriate Discord webhook. 
This repository is coded in dotnet.

Setup instruction:
01) Create an AWS Lambda function. Choose .Net 6(C#/PowerShell) as the runtime and upload the published code.
02) Define the environment variable in lambda:-
    - discord_id		- Discord webhook id
    - discord_token	- Discord webhook token
03) Change the handler to AzureDevOpsDiscord::AzureDevOpsDiscord.Program::Handler
04) Create an HTTP API in AWS API Gateway
05) Add integration with the lambda function. Choose Version 2.0
06) Define your preferred route.
07) Create a webhook in Discord, take note the URL will contain the discord id and token.
08) Create Azure Devops webhook from Project Settings -> Service Hooks.
09) Add Web Hooks. Currently only these events is supported: Build Completed, Pull Request Created, Updated and Commented On
11) Fill in the URL with this format: (https://[Api_Url]/[Route])
12) Test and save the webhook.

The diagram below shows how the flow work. 

![](architecture.png)

### Resources
https://discordapp.com/developers/docs/resources/webhook#execute-webhook
