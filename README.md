# Introduction 
This project was created for the purposes of testing OWASP Top 10 2021 Web vulnerabilities against LVVWD static code analysis tools. It is a .NET 6 project. 

# Getting Started
1.	Installation process:
    1. In order to run this applicaiton you must have SQL Server installed on your machine.
    2. Open the sql folder and run the SQL scripts in turn:
        1. Create_DB_and_user.sql
        2. Create_BadHairDay.sql
        3. Grant_BadHairDay.sql
        4. Insert_BadHairDay_Data.sql 
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test


# Contribute
Fork and add vulnerabilities as needed.

#Vulnerabilities
* A01: All pages can be side-loaded and are not checking to see if a user is logged in.
* A02: Passwords are stored in clear text for the user login in appsettings.json, and the DB connection string is hard coded.
* A03: SQL Injection attacks are allowed by not paramaterizing queries. 
* A04: The password recovery system is simply a "question and answers" system, which is prohibited.
* A05: The A03/A05 page dumps the exception to the screen as it is not placed in a try/catch block to handle an exepction.
* A06: The A06 page uses an old version of JQuery 2.0.0, which has vulnerabilities.
* A07: The login page makes no attempt to limit bad login attempts. A brute force attack could easily get in.
* A08: Passes data back and forth from the server to the client in JSON format and does not validate anything.
* A09: The app does no logging at all, which fails A09 (Security Logging and Monitoring Failures).
* A10: The app lets a user enter an arbitrary URL, the server side code GETs that URL and returns the plain text to the client, without validating anything.

