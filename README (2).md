
# Gym Membership Software By CRUD using SQL in C#

Here you can insert data, update data , delete and search for data. Easier to store huge amount of data and find easily. 


## Preview
![App Screenshot](https://cdn.discordapp.com/attachments/1007233588066009169/1283148703930257498/Screenshot_4.png?ex=66e1f0da&is=66e09f5a&hm=1adef2f7ad12da2c66025039069e4f598df9c235b406250b2882a5489384c8a1&)


## Acknowledgements

https://youtu.be/aer8S1fFbNc?si=ytdG6cPeE6nMECsj

https://youtu.be/4bQfxbSj4tg?si=WX12V9Oxufksr0wr


## Features

Insert: Add new user data to the database.

Delete: Remove existing user data based on userid.

Update: Modify details of a selected user.

Search: Search for the existing data from the datagridview


## Demo

https://youtu.be/-MuR3eNF3NY?si=HdHrq2lDqUtiiHo2


## SQL Query
Table Design

CREATE TABLE [dbo].[Practice] ( [ID] INT (50) NULL, [Name] VARCHAR (50) NOT NULL, [Age] INT NOT NULL, [Type] VARCHAR (50) NOT NULL, [Contact] datetime NOT NULL, [EnrollDate] PRIMARY KEY CLUSTERED ([MemberID] ASC) );

Insert

"Insert into Practice values ('" + int.Parse(textBox1.Text) + "','"

textBox2.Text + "','"
int.Parse(textBox3.Text) + "','"
(comboBox1.Text)
"',getdate(),getdate())", con
Update

update Practice set MemberName='" + textBox2.Text

"',Age='" + textBox3.Text
"',Gender='" + comboBox1.Text
"',UpdateDate= '"+DateTime.Parse(dateTimePicker1.Text)+"' where MemberID= '"+int.Parse(textBox1.Text)+" ' ", con
Delete

Delete Practice where MemberID= '" + int.Parse(textBox1.Text) + "'", con

Search

select * from Practice where MemberID= '"+int.Parse(textBox1.Text)+"'", con


## FAQ

#### How much data can I entry?

As much as you want.

#### Can I edit a data after entry?

Yes you can.


## Technology

Programming Language: C#

Database: SQL Server

Framework: Windows Forms

UI Components:

Text Box for entering data.
Button for response.
Data Grid View for displaying and managing data
## Skills

C#

NET Framework

SQL Server

Windows Forms Development
