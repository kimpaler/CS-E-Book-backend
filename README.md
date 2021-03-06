# CseBook-v2-with-auth

### To run:

1. Navigate to CseBookApi-v2-with-auth
2. Execute `dotnet run`
3. API will run at http://localhost:4000
4. Test VALID and INVALID sample data on POSTMAN: http://localhost:4000/user/authenticate
5. Try out other username and password pair on login that is not on the sample data
6. Try out other API endpoints as well. Check API Docs for guide. :)

### API Docs

1. Open browser and navigate to: http://localhost/4000
2. Note that other endpoints are not yet finalized.

### Sample data
1. u: perea; p: password; grade_level: "1st"; course: "CPE"; -----> `VALID`
2. u: mediola; p: password; grade_level: "1st"; course: "CPE"; -----> `VALID`
3. u: orale; p: password; grade_level: "1st"; course: "CPE"; -----> `VALID`
4. u: gabon; p: password; grade_level: "1st"; course: "CPE"; -----> `VALID`
5. u: user; p: user; grade_level: "1st"; course: "IT"; -----> `INVALID`

### To see SQLite db contents:

1. Download SQLite DB Browser: https://sqlitebrowser.org/dl/
2. Launch SQLite DB Browser and open LocalDatabase.db

### TO DO:

- Apply correct error response code, improve error handling
- Endpoints:
  - **User:  (DONE, Needs polishing and applying correct response code)**
    - POST user/authenticate ------> working :)
    - POST user/register ------> working :)
    - GET user
    - GET user/{id} ------> working :)
    - PUT user/{id} ------> working :)
    - DEL user/{id} ------> working :)
  - Chapter
    - ???
  - **UserChapter: (DONE, needs polishing and applying correct response code)**
    - GET userchapter ------> working :)
    - GET userchapter/{id} ------> working :)
    - GET userchapter/user/{userId} ------> working :)
    - POST userchapter ------> working :)
    - PUT userchapter/{id} ------> working :)
    - PUT userchapter/user/{userId}/chapter/{chapterId} ------> working :)
    - DEL userchapter/{id} ------> working :)
    - DEL userchapter ------> working :)
  - Question
    - ???
  - **Answer: (DONE, needs polishing and applying correct response code, 'SEND TO TEACHER' AND 'CHECKING CORRECTNESS OF ANSWER' NOT YET IMPLEMENTED)**
    - POST answer/{answer_id} ------> working :)
    - PUT answer/{answer_id} ------> working :)
    - GET answer ------> working :)
    - GET answer/{answer_id} ------> working :)
    - DELETE answer/{answer_id} ------> working :)

### Note:

1. For future plans, if we want to update SQLite to SQL Server ----> Eazy Peazy XD

---

# CseBook

### REST API
in json format.
|        | API	             | Description	           | Request body |	Response body        |
|--------|-------------------|-------------------------|:------------:|:--------------------:|
| GET    | /api/Answers      | Get all to-do items	   | None	        | Array of to-do items |
| GET    | /api/Answers/{id} | Get an item by ID	     | None	        | To-do item           |
| POST   | /api/Answers	     | Add a new item	         | Answer item  | To-do item           |
| PUT    | /api/Answers/{id} | Update an existing item | Answer item	| None                 |
| DELETE | /api/Answers/{id} | Delete an item          | None	        | None                 |
#### Open Visual Studio Code
CTRL+\`
and if packages are not yet added:
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-aspnet-codegenerator
```

Tool to generate Controllers and probably others
Sample usage:
```bash
dotnet aspnet-codegenerator controller -name AnswersController -async -api -m UserAnswer -dc AnswerContext -outDir Controllers
```
generates AnswersController, for [UserAnswer](https://raw.githubusercontent.com/pereav/cs-e-book/master/AnswerApi/Models/UserAnswer.cs) model, to dbcontext [AnswerContext]((https://raw.githubusercontent.com/pereav/cs-e-book/master/AnswerApi/Models/AnswerContext.cs)) (currently InMemory)

#### To run
Go to Visual Studio Code and press CTRL+F5
* URLs: localhost:5000 & localhost:5001
for example: access 1st answer in localhost:5000/api/Answers/1

#### Postman
* To test API, Disable SSL certificate verification
** From File > Settings (General tab), disable SSL certificate verification.
** Warning: Re-enable SSL certificate verification after testing the controller.
For more info, see Install Postman section [here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code#install-postman)

### Tutorial
[ASP.NET](https://github.com/pereav/cs-e-book/issues/8)

