# Discourse Chapter 1

## Week 1 - C# String Concatenation Practice

### Overview

This practice demonstrates how to:

* Create string variables
* Combine multiple values
* Store the combined value in another variable
* Display the result using a Label control
* Clear the input fields
* Close the Windows Form

---

## 1. Creating Variables

In this step, variables are created to store the user's date information:

* `dayof_theweek` - stores the day of the week
* `name_of_month` - stores the name of the month
* `numeric_day` - stores the numeric day
* `year` - stores the year
* `full_date` - stores the complete date after combining all the values

The variables are declared in C# as follows:
![Creating Variables](screenshoot/create_variables.png)

```csharp
string dayof_theweek, name_of_month, full_date;
int numeric_day;
int year;
```

---

## 2. Getting Values from TextBoxes

The values are entered by the user through TextBox controls.

The `.Text` property is used to get the values from the TextBoxes.

```csharp
dayof_theweek = textdayofweak.Text;
name_of_month = textmounth.Text;
numeric_day = int.Parse(textnumeric.Text);
year = int.Parse(textyear.Text);
```

The `int.Parse()` method converts the text entered by the user into an integer.

![value to variables](screenshoot/value_to_variables.png)

---

## 3. Concatenating the Date Values

In this step, the values are combined using the `+` operator.

Spaces and commas are added to make the final date easier to read.

```csharp
full_date = dayof_theweek + ", " + name_of_month + ", "
          + numeric_day + ", " + year;
```

For example, if the user enters:

* Day: `Wednesday`
* Month: `September`
* Numeric Day: `23`
* Year: `2026`

The result will be:

```text
Wednesday, September, 23, 2026
```

The complete value is stored in the `full_date` variable.

![process concatination](screenshoot/process_concatination.png)

---

## 4. Displaying the Full Date

After the values are combined, the value stored in `full_date` is displayed in a Label control.

The `.Text` property of the Label is used to display the result on the Windows Form.

```csharp
lbloutput.Text = full_date;
```
![output using label](screenshoot/output_using_label.png)


---

## 5. Clear Button

The Clear button removes all values entered in the TextBoxes.

```csharp
textdayofweak.Clear();
textmounth.Clear();
textnumeric.Clear();
textyear.Clear();
```

The output Label is also cleared:

```csharp
lbloutput.Text = " ";
```
![create and clear label](screenshoot/create_and_clear_label.png)

---

## 6. Close Button

The Close button closes the current Windows Form.

```csharp
this.Close();
```
![close](screenshoot/close.png)

---

## Conclusion

This practice demonstrates the basic use of:

* Variables
* String values
* Integer values
* TextBox controls
* Label controls
* `int.Parse()`
* String concatenation using `+`
* `.Text` property
* `.Clear()` method
* `Close()` method
* Windows Forms event handlers
