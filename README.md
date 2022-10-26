### Third Practical Work for the .Net Programming Course

#### Model the Persona (Person) class with the following conditions:

Attributes: nombre (name), e-mail, sueldo (salary), sexo (gender), peso (weight) and altura (height). 
Think about which visibility modifier is the most appropriate along with the type of each one since its attributes should not be accessed directly.

Implement a constructor that defines all the attributes by parameter except the e-mail that is specified later.

Methods to implement:
◦ All Getters methods, Do not implement Setters.

◦ CrearEmail(): Creates the person's e-mail from the name + @superempresa.com. This method is private and is called via the constructor.


#### In the Main function of the Program.cs class do the following:

1. Ask by keyboard for name, salary, gender, weight and height and create 1 person object.

2. Show the complete information of the person in this format:
-Name: Juan
-Email: Juan@superempresa.com
-Salary: 30000 ARS
-Gender: Male
-Weight: 70kg(B)
-Height: 1.7m
