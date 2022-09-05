dotnet ef database update -c PeopleContext


dotnet ef database update -c PeopleConcurrencyContext


dotnet ef migrations add -c PeopleConcurrencyContext InitialCreate