## Database (dotnet ef)

### Create Migration

``` shell
dotnet ef migrations add initial --project Frigor.DataAccess --startup-project Frigor.WebApi/
```

### Update Database

``` shell
dotnet ef database update --project Frigor.WebApi/
```

## Clear DB then Update

``` shell
docker rm frigor_db -f && docker volume rm frigor_db
```
