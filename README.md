# NA-203-Notes

#### 10/11/2021
Firstly, we defined variables and printed theirs max values.
Data types: *char *string  *decimal  *float  *double *sbyte  *float...
Here is a short version of data types table:
Type | Range
------------ | -------------
int | -2,147,483,648 to 2,147,483,647
byte | 0 to 255
sbyte | -128 to 127
short | -32,768 to 32,767
double| -1.79769313486232E+308 to 1.79769313486232E+308

To learn the type of a variable use GetType() method for instance x.GetType()

var x= 55;
var y =34.23d; 

Console.ReadLine() get user inputs.

## Reference Type
These reference types hold a reference to the location of the data.
if you change the variable value, the latest value is your new variable value.<br />
**String** and **string** are not the same thing. String:  create String Object
string: data type.<br /> When you define a value using **var** it retains the first attributed value type.


## Operators

** +, -, *, /, % **
```
int a, b, c, d, result;
a = 2;b = 3; c = 4; d = 6;
result = a+b*(c+d)-a;
Console.WriteLine($"Result:{result}")
```


## Logical Operators
 

Operator | Description
------------ | -------------
**||** |  Logical Or Operator
**&&** | Logical And Operator
**!* | Logical Not Operator 

## Bitwise Operators
They work on bits

```
byte num1 = 5; //0101
byte num2 = 3; //0011
int control7 = num1 & num2;// =>    0001
int control8 = num1 | num2;// =>    0111
byte control9 = (byte)~num2;
Console.WriteLine(control7);
Console.WriteLine(control8);
Console.WriteLine(control9);
```

## Type conversions
Here, we are converting a type to an other type. To give an example, we can convert an integer to a float.

```
int num = 305;
byte byteNum = (byte)intSayi;
byte byteNum2 = Convert.ToByte(num)
```