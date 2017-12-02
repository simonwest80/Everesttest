---
title: Smart Filter
---

# Smart Filter


Use the **Smart Filter** to select  accounts based on your segments. Wildcards can be used in this field and  up to 250 characters can be entered. **Segment 
 Separators** must be entered between segments. Enter a semi-colon  (**;**) to separate accounts in the  **Smart Filter**.


| Smart Filter Wildcard | Meaning |
| ? | One Character |
| \* | Multiple Characters |



{:.example}
A company has a segment format of DIV-DEP-PRODUCT-ACCT  (Division, Department, Product, and Account). The accountant wants to  know the sales figures (Account 4000) for Product ABC in all Divisions  and Departments and also wants to see sales figures for Product XYZ for  Division 001 only.


The following is entered in the **Smart 
 Filter** field:


\*-\*-ABC-4000; 001-\*-XYZ-4000


The meaning of this entry is further explained in the following table:


| Character or Characters | Meaning |
| \*-\*-ABC-4000 | All Divisions, All Departments, Product ABC, and Account  4000 |
| ; | Separator used to separate smart filter requests |
| 001-\*-XYZ-4000 | Division 001, All Departments, Product XYZ, and Account  4000 |



{:.see_also}
See also
: [Segmented  Chart of Accounts]({{site.sc_chm}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)
