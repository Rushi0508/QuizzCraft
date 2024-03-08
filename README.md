# QuizzCraft

## How to Run this project ?

> Clone this Repository

```
git clone https://github.com/Rushi0508/QuizzCraft.git
```

### 1. App.config (QuizzCraft - Service) - Connection String

```xml
<connectionStrings>
	<add name="QuizzConnection" connectionString="Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = QuizzCraft; Integrated Security = True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 2. Install Nuget Packages

```
Microsoft.EntityFramework
BCrypt.Net-Next
```


### 3. For DataBase Migration (If require then use otherwise it is created automatically)
> First time only to Enable Migration
```
Enable-migration 
```

```
add-migration "migrationName"
update-database
```

## Tech Stack

| Application        | Tech                  |
| ------------------ | --------------------- |
| Backend            |  SOAP Services         |
| Host               |  Windows Form         |
| Frontend           |  WebForms (BootStap)  |
| DataBase           | SQL (SSMS)            |

> Team members

<table>
  <tr>
    <td align="center">
        <a href="https://github.com/Rushi0508/QuizzCraft/graphs/contributors">
            <img src="https://github.com/Rushi0508.png" width="100px;" alt=""/>
            <br />
            <sub><b>Rushi-Gandhi</b></sub>
        </a>
        <br />
    </td>
    <td align="center">
        <a href="https://github.com/Rushi0508/QuizzCraft/graphs/contributors">
            <img src="https://github.com/Sandip-Kanzariya.png" width="100px;" alt=""/>
            <br />
            <sub><b>Sandip-Kanzariya</b></sub>
        </a>
        <br />
    </td>
    </tr>
</table>
