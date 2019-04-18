# Cocktail Cookbook
AMIS 3610 SP19 Course Project
By Joey David, Brendan Getts, Max McElligott, Max Harendza, Alex Paratore

Azure:
http://cocktaildoey77.z19.web.core.windows.net/landing

### To run
1) In a terminal, type 'git clone https://github.com/Getts4/cocktail-cookbook' into a workspace folder
2) In the 'cocktail-cookbook\api' directory, run 'dotnet restore' from terminal (VSCode may prompt to restore on its own as well)
3) In the 'cocktail-cookbook\web' directory, run 'npm install' from terminal
4) Install PostgreSQL (https://www.enterprisedb.com/downloads/postgres-postgresql-downloads). Once installed, created a Login user named 'cocktail_user' with password '12345' and all privileges
5) In the 'cocktail-cookbook\api' directory, run 'dotnet ef database update'(run 'dotnet ef database drop' and then update to re-do the database, if necessary)
6) Create another terminal. Set one to the 'cocktail-cookbook\api' directory and one to the 'cocktail-cookbook\web' directory. In web, run 'ng serve', and in api, run 'dotnet run'
7) Navigate to 'http://localhost:4200' to see the app in action

NOTE: you can also use the internal Angular database by changing the drinksUrl in '\web\src\app\_services\drink.service.ts' to 'api/drinks'
