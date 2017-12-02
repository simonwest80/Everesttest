---
title: The Country Profile - Format Address
---

# The Country Profile - Format Address


Use this tab to specify the address format for a particular country.


**Extended Address Description**
: Specify the address format for the country using  this field. Right-click in the field and use the pre-defined tags in **Everest** to specify the format.


{:.note}
In addition to tags you can enter other characters such as Space, Enter,  <, >, %, etc.


{:.example}
If you want all US addresses to be printed as:


Jane Alexander


5121 St. Wood Dr


Apt 300


Centerville,  VA 20120


United States of America


You should specify the format as:


$First Name$  $Last Name$


$Street Address Line 1$


$Street Address Line 2$


$City$, $State$  $Postal Code$


$Country$
: The formatted address can be viewed in the following  profiles:

- Vendors (Purchasing  > Vendor)
- Customers (Invoicing  > Customers)
- Locations (File  > Setup > Accounting > Location)
- Users (File  > Setup > Users > Users)



{:.note}
The field chooser for the formatted address  is called "Address Memo" in the **Locations/Sub-Locations** and **Users** browsers, while  in the document browsers it is " Billing Address", "Shipping  Address" (or Return Address), and "Contact Address".
: This field can be added to the browser from the  [Field  Chooser]({{site.wwe_chm}}/everest-client/ui/browsers/options/field-chooser/browser_options_field_chooser.html) <font style="color: #000000;" color="#000000">and used in the label designer to print 
 labels with formatted addresses. The format specified here will be used 
 while printing the shipping labels for the documents created for the respective 
 country.</font>


{:.see_also}
See also
: [The Country Profile]({{site.sc_baseurl}}/options/international-set-up/country/profile/the_country_profile.html)
