<a name="readme-top"></a>
<h1 align="center">epadoca-WebVersion</h1>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<br />
<div align="center">
  <a href="https://github.com/Flaviojcf/epadoca-challenge">
    <img src="~/img/epadoca.gif" alt="Logo">
  </a>


  <p align="center">
    This project is a solution to the epadoca internship challenge
    <br />
    <a href="https:/github.com/flaviojcf/epadoca-challenge"><strong>Explore the code »</strong></a>
    <br />
    <br />
  </p>
</div>

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <ul>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#pre-requisites">Pre-requisites</a></li>
      </ul>
    </li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

## Screenshots


<div align="center">
    <img src="~/img/epadoca-1.png"  >
    <img src="~/img/epadoca-2.png"  >
    <img src="~/img/epadoca-3.png"  >
    <img src="~/img/epadoca-4.png"  >
</div>



### Built With


- [![Asp][asp.net]][asp-url]
- [![Bootstrap][bootstrap]][bootstrap-url]
- [![Jquery][jquery]][jquery-url]
- [![Ajax][ajax]][ajax-url]
- [![SQL-Server][SQL-Server]][SQL-Server-url]
- [![Entity-Framework][Entity-Framework]][Entity-Framework-url]






### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/Flaviojcf/epadoca-challenge.git
   ```
2. <a href="#pre-requisites">Go to Pre-requisites</a>

3. In Visual Studio Code <br/>

    Install ef
   ```sh
   dotnet tool install --global dotnet-ef
   ```
    Update the migration
     ```sh
    dotnet ef database update
   ```
    Run the project
    ```sh
    dotnet run
    ```
4. In Visual Studio
    ```sh
    Open the package manager console and write: "Updata-Database -Context BakeryDbContext"
    ```
5. Run the project
     ```sh
    Run the project
    ```

### Pre-requisites

- SQL Server
  ```sh
  https://www.microsoft.com/pt-br/sql-server/sql-server-downloads
  ```
- Create a user in database and change the authentication mode in SQL Server
   ```sh
  https://learn.microsoft.com/pt-br/sql/database-engine/configure-windows/change-server-authentication-mode?view=sql-server-ver16
  ```
- Set the path to database and user informations in appsettings.json
   ```sh
  Example: "DataBase": "Server='path-database-example';Database='database-name-example';User Id='user-id-example';Password='user-password-example'"
  ```







## Contact

[@flavio_jCosta](mailto:flaviojcostafilho@gmail.com) - flaviojcostafilho@gmail.com

Project Link: [https://github.com/Flaviojcf/epadoca-challenge](https://github.com/Flaviojcf/epadoca-challenge)

<p align="right">(<a href="#readme-top">back to top</a>)</p>




[contributors-shield]: https://img.shields.io/github/contributors/flaviojcf/epadoca-challenge.svg?style=for-the-badge
[contributors-url]: https://github.com/flaviojcf/epadoca-challenge/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/flaviojcf/epadoca-challenge.svg?style=for-the-badge
[forks-url]: https://github.com/flaviojcf/epadoca-challenge/network/members
[stars-shield]: https://img.shields.io/github/stars/flaviojcf/epadoca-challenge.svg?style=for-the-badge
[stars-url]: https://github.com/flaviojcf/epadoca-challenge/stargazers
[issues-shield]: https://img.shields.io/github/issues/flaviojcf/epadoca-challenge.svg?style=for-the-badge
[issues-url]: https://github.com/flaviojcf/epadoca-challenge/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/flávio-jcosta

[asp.net]: https://img.shields.io/badge/ASP.NET-9017C0?style=for-the-badge&logo=ASP.NETrk&logoColor=white
[asp-url]: https://dotnet.microsoft.com/en-us/apps/aspnet

[bootstrap]: https://img.shields.io/badge/Bootstrap-7211F1?style=for-the-badge&logo=Bootstrap&logoColor=white
[bootstrap-url]: https://getbootstrap.com/

[jquery]: https://img.shields.io/badge/Jquery-78CFF5?style=for-the-badge&logo=Jquery&logoColor=white
[jquery-url]: https://jquery.com/

[ajax]: https://img.shields.io/badge/Ajax-78CFF5?style=for-the-badge&logo=Ajax&logoColor=white
[ajax-url]: https://api.jquery.com/jquery.ajax/

[SQL-Server]: https://img.shields.io/badge/SQL-Server-67F7FF?style=for-the-badge&logo=SQL-Server&logoColor=white
[SQL-Server-url]: https://www.microsoft.com/pt-br/sql-server/sql-server-downloads

[Entity-Framework]: https://img.shields.io/badge/Entity-Framework-652076?style=for-the-badge&logo=Entity-framework&logoColor=white
[Entity-Framework-url]: https://learn.microsoft.com/en-us/ef/
