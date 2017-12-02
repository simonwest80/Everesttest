---
title: POS Cash Registers Browser
---

# POS Cash Registers Browser


The **POS Cash Registers** browser  displays all available cash registers based on the following order of  precedence:

- **Cash 
 register assigned to the logged in user** - If the logged in user  is assigned a cash register, only that cash register is displayed.



{:.note}
If the cash register assigned to the logged in user  belongs to a location/sub-location other than the login location/sub-location,  it is NOT displayed.

- **User’s 
 Location/Sub-Location-** If no cash register is assigned to the logged  in user, cash registers that belong to the user's location/sub-location  in the **User** profile and cash registers  that are NOT assigned to any location/sub-location are displayed.
- **Login 
 Location/Sub-Location**- If  no  cash register is assigned to the logged in user and the user is not assigned  to a location/sub-location, cash registers assigned to the login location/sub-location  and cash registers NOT assigned to any location/sub-location are displayed.



{:.note}
You can assign a cash register to the logged in user  in the **Cash Register** field of  the **User** profile (path: **File &gt; Setup &gt; Users &gt; Users &gt; 
 Options &gt; Edit &gt; In New Window &gt; Miscellaneous** tab).


You can assign a location/sub-location to the logged  in user, in the **Location/Sub-Location** field of the **User** profile  (path: **File &gt; Setup &gt; Users &gt; 
 Users &gt; Options &gt; Edit &gt; In New Window &gt; Miscellaneous** tab).


{:.see_also}
See also
: [POS  Cash Registers Browser Options]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-cash-registers-browser/options/pos_cash_registers_browser_options.html)
