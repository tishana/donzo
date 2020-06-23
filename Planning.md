My plan for an app is a workout app called Donzo.

A user will be able to do the following things in this app

1. Create a workout entry. (Add New Workout)
2. Update a workout entry. (Edit Workout)
3. View one workout (View Workout)
4. See all workout entries. (View Workouts)
5. Delete a workout entry. (Delete Workout)
6. Export a list of Workouts. (Export Workouts)

Create Read Update Delete covered.

FrontEnd/ Angular

The frontend or user interface side of Donzo is where the user will be able to enter all of thrier information pertaining to workouts. There will be a form for workout entries that will include:
1. date, 
2. workout type (a dropdown from a list),
3. duration (in minutes),
4. mood after workout (from a dropdown list) *optional

The user will also be able to view all of their workouts on a separate screen (Edit/View Workouts). 

A user will be able to edit a workout entry form (Update) with a button on the View Workouts screen and/or a button on the View Workout screen .

Hope to be able to add if there is time:

- Login and Account Profile for multiple users.


Backend/ .NetCore

API will handle the following queries to and deliver data from the database to the frontend:

Create Workout (POST)
View Workout (GET one)
Edit Workout (PUT)
View Workouts (GET all)
Delete Workout (DELETE one)
Export Workouts (possibly to excel spreadsheet or plain txt to user's email)


Database

Entities:

User - username, first name, last name, email, password (?)
Workout - date, type, duration (in minutes), mood
