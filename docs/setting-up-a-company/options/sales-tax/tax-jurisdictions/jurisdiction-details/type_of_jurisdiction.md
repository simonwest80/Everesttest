---
title: Type of Jurisdiction
---

# Type of Jurisdiction


Jurisdictions are of two types - **Out**  and **In**.


An **Out** type jurisdiction is  created for out of state sales and has no FIPS/Postal codes assigned to  it.


An **In** type jurisdiction is created  for sales taxes that apply within the state or county. It has FIPS/Postal  codes assigned.


{:.note}
For every state in which you have a business  presence, you must create an 'OUT' jurisdiction to accumulate out of state  sales, before defining other jurisdictions. No FIPS Code is defined for  this Jurisdiction.


{:.example}
If you have a business presence in Virginia,  define the OUT jurisdiction i.e. a Jurisdiction having the name 'Out of  state sales - Virginia'. Select the option <font face="verdana" class="hcp7">'</font>Out<font face="verdana" class="hcp7">'</font> and do not associate any FIPS Code with it.


You cannot create more than one **Out**  type jurisdiction for the same State. If you try to do so, you are informed  that an **Out** type Jurisdiction  already exists for that State.


{:.note}
<font color="#000000" class="hcp8">&nbsp;</font>You  can select only an **In** type of  jurisdiction while logging in. By default, an **In**  jurisdiction with the code **DEF**  is created with a new company. It  has  no effect on any of your transactions and is only for the purpose of logging  in. You need to create your own jurisdictions in order to enable the system  to determine the correct tax jurisdictions.


<font color="#000000" class="hcp8">In the case of countries other than the United States, 
 you must define a default jurisdiction in addition to the taxable jurisdiction 
 for EVERY state or county of that country. This gives you a detailed breakup 
 of sales.</font>


{:.see_also}
See also
: [The **Jurisdiction**  Profile]({{site.sc_baseurl}}/options/sales-tax/tax-jurisdictions/set-up-jurisdictions/jurisdiction_profile.html)
