![Image](https://github.com/RobinKim-SWEngineer/Images-for-document/blob/master/HappyProgrammer%20(1).jpg)

# ListToDataTable Converter

## What is this snippet about ?

This is a code snippet that can convert **a list of data types to a data table**. This conversion is necessary when we need to export the query result into a excel file because when working with Database, we get the data set from DB as a list of model objects.

> When it comes to working with database, Dapper is a handy library that does relational mapping for us between C# object <--> Query result, which reduces the amount of code dramatically. 

## How this snippet is written ?

1. Getting property value from *object* type using System.Reflection
   - First we need to get **type** out of object and obtain **propery** from that type 
   
   - When getting type, we do either by `typeof(T)` or `obj.GetType()`, assuming that the argument is passed to Converter() method as `List<T> listOfObjects`.
   
   - Once we get type of the object, we apply either `.GetProperties()`, which returns an array of all properties included inside the type  **or** `.GetProperty(string propName)` and further `.GetValue(object obj)`.

2. Putting into DataTable 
   - For title row,  we loop through `typeof(T).GetProperties()` and apply `.Name`upon each property. 
   
   - For content rows, the process is same but two loos are required. Outer one loops through **list Of Objects** while inner one loops through **properties** in each object.
   
   - Upon each loop of a object, a row is added to DataTable using `.Add(DataRow row)` 
