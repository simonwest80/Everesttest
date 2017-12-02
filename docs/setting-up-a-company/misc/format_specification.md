---
title: Format Specification
---

# Format Specification


The formats for the telephone, mobile and zip codes are represented  by masks. Masks have the following special characters.


| Mask | Description |
| ! | If a ! character appears in the mask, optional characters  are represented in the EditText  as leading blanks. Otherwise, they are represented as trailing blanks. |
| > | If a > character appears in the mask, all characters  that follow are in uppercase until the end of the mask or until a <  character is encountered. |
| < | If a < character appears in the mask, all characters  that follow are in lowercase until the end of the mask or until a >  character is encountered. |
| <> | If these two characters appear together in a mask, the  user can format  the  data in any case. |
| \ | The character that follows a \ character is a literal  character. Use this character to use any of the mask special characters  as a literal in the data. |
| L | The L  character requires an alphabetic character only in this position. For  the US, this is A-Z,  a-z. |
| l | The l  character permits only an alphabetic character in this position, but does  not require it. |
| A | The A character requires an alphanumeric character only  in this position. For the US, this is A-Z,  a-z, 0-9. |
| a | The a character permits an alphanumeric character in  this position, but does not require it. |
| C | The C  character requires an arbitrary character in this position. |
| c | The c  character permits an arbitrary character in this position, but does not  require it. |
| 0 | The 0 character requires a numeric character only in  this position. |
| 9 | The 9 character permits a numeric character in this  position, but does not require it. |
| # | The # character permits a numeric character, or a plus  or minus sign in this position, but does not require it. |
| : | The : character is used to separate hours, minutes,  and seconds in times. If the character that separates hours, minutes,  and seconds is different in the regional settings of the Control Panel  utility on your computer system, that character is used instead. |
| / | The / character is used to separate months, days, and  years in dates. If the character that separates months, days, and years  is different in the regional settings of the Control Panel utility on  your computer system, that character is used instead. |
| ; | The ; character is used to separate the three fields  of the mask. |
| \_ | The \_ character automatically inserts spaces into the  text. When the user enters characters in the field, the cursor skips the  \_ character. |

