---
title: Calculation Type
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.prl_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
\* Year to date = Year to date value of Local Tax Taxable amount

# Calculation Type


The calculation type identifies how the local tax is calculated. The  calculation types can be any one of the following:

- **% 
 of Federal** - The local tax is calculated as a percentage of the  federal income tax of the employee.
- **% 
 of State** - The local tax is calculated as a percentage of the state  income tax of the employee.
- **% 
 of Gross** - The local tax is calculated as a percentage of the gross  salary of the employee.
- **% 
 of Net Salary** - The local tax calculated as a percentage of net  salary of the employee.
- **Flat 
 Amount** - You are required to specify a flat amount to be deducted  from the employee's earnings.
- **Based 
 on the Hours Worked** - The local tax is calculated at a rate based  on the number of hours worked by the employee.



{:.note}
For the calculation type set to % of Gross  or % of Net Salary, the local tax is calculated in the following manner:

- Min1 = Minimum  of (Local Tax Taxable amount) or (Local Tax Taxable amount + [Year to date](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>  - Lower Limit set in the **Local Tax**  profile)
- Min2 = Minimum  of (Taxable amount) or (Upper Limit set in the **Local 
 Tax** profile - Year to date)
- Min3 = Upper Limit  - Lower Limit set in the **Local Tax**  profile



If Lower Limit and Upper Limit are greater  than zero, the least of Min1, Min2 and Min3 is considered to calculate  the Local tax. Local tax is calculated as a percentage of Net Pay/Gross  Pay.


If Upper Limit is greater than zero, **Everest** calculates Min1 amount, as stated  above, to arrive at the Local Tax amount.


If Lower Limit is greater than zero, **Everest** calculates Min2 amount, as stated  above, to arrive at the Local Tax amount.


{:.see_also}
See also
: [Tax Details]({{site.prl_baseurl}}/setup/local-taxes/tax_details.html)
