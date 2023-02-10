# Web API for Team Schedule Management System
Is the backend of the system written in C# language on .Net Core platform
## The system consists of 3 parts (``App Android, Admin website, Web API``)
- [Android application written in kotlin language](https://github.com/GrayWolf52/khoaLuan)
- [Admin Web written in framework Vue.js](https://github.com/GrayWolf52/web-quan-tri-khoa-luan)
- [Wep Api is backend written in c# language (.Net 3.1)](https://github.com/GrayWolf52/DoAn_BE)

### You need install
- Environment: [.Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
- IDE: [Visual Studio](https://visualstudio.microsoft.com/fr/)

### How to connect backend with database ([tutorial link](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs&fbclid=IwAR0-UXyqCFxVre2rRyFmOC_vCrakHsa8Hh6__bWuZx8gRzNeNEHSVudqJmM#tabpanel_2_vs))
(You need install [SQL server managerment studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) to manage data)
- Open ``Package Manager Console`` in Visual Studio

![visual 1](https://user-images.githubusercontent.com/56286032/218137891-429acd1c-0069-4f34-88c6-c0fee56a9443.png)

- Input command 

```
Add-Migration InitialCreate
```
```
Update-Database
```
### How to run backend for app and admin web
- Open cmd in folder \SheduleManagement

![be](https://user-images.githubusercontent.com/56286032/218140279-f4c9fb74-0c59-470d-9a7a-6fb28f6dc8da.png)
- Input command to run
```
dotnet run
```
![be2](https://user-images.githubusercontent.com/56286032/218141158-002a4ed6-7027-4c86-b26d-ea7c2e7c5692.png)

Now, you can run app or admin web!!!
