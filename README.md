# Episode Application from Code Magazine May/June & July/August 2021 Issues

This was a 2-part article.

## Part 1: ["Can You Keep a Secret? Azure Can!"](https://www.codemag.com/Article/2105041)
Where I show you how to use an Azure Managed Identity to access a secret (in this case a connection string) stored in Azure Key Vault for accessing an Azure SQL database.  

This article focused on the working in Visual Studio to debug the ASP.NET Core web app using EF Core while keeping the connection string out of the application.
  
## Part 2: "Eliminate Secrets from Your Applications with Azure Managed Identity " (link coming when article is online)  

In this article I extend the demo by publishing the web app to Azure then using Managed Identity so that only this application had permission to interact with the database. Not only were the secrets (the connection string) eliminated from the application code, but the connection string no longer requires the credentials (user id ad password) within the string.  

## Repository Branches  
The **main** branch contains the final solution.  

If you'd like to follow the steps in the article, the **StartingPointApp** branch contains the simple website before I start engaging Key Vault or Managed Identity.


