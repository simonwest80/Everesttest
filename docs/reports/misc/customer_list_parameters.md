---
title: Customer List Dialog Box
---

# Customer List Dialog Box


Use the **Customer List** dialog  box to set the parameters for your **Customer 
 List** report. The **Customer List**  report does NOT display Point of Sale (POS) customers.


**Sort By**
: Select this option to sort the report by **Customer 
 Code**, **Name**, or **Sales 
 Rep**.


**Code From**
: Specify the starting code **** for the range of customers, to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Code To**
: Specify the ending code for the range of customers,  to be included in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


{:.note}
If values are not specified in the **Code 
 From** and **Code To** fields,  by default all customers are included in the report.


**Customer Status**
: Select the status of the customers to be included  in the report. The options available in this field are:


| **Active** | To include all customers that are in use. |
| **Inactive** | To include all customers that are discontinued. |



**Report Type**
: This field gives you the option to generate a summary  or detail report.


| **Summary** | Select this option to view information such as the contact  address, telephone numbers and city of the customers. |
| **Detail** | Select this option to view additional information such  as date of creation, credit limit, hold, status, level and location/sub-location  of the customers. |



**Created After**
: Specify the start date of the period during which  the customer was created.


**Created Before**


Specify the end  date of the period during which the customer was created.


{:.note}
If values are not specified in the **Create 
 After** and **Create Before** fields,  then, the current date is displayed in these fields.


{:.example}
If you forget the code or name of a customer  you created during the first quarter of year 2000, you can give the date  range as January 1, 2000 to March 31, 2000 for generating a list of all  customers created during that period.


**Sales Person**
: Specify the code and name of the sales representative  to generate a list of customers assigned to the specified sales representative.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Created By**
: Specify the user name to generate a list of customers  created by the specified user.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Drop-Down  List - Right-Click Menu Options]({{site.rpt_baseurl}}/common-report-options/drop_down_button_and_menu_options.html)


**Shipping Address**
: Select this check box to include the customer’s  shipping address in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Shipping  Address]({{site.mc_chm}}/customer-details/addresses/shipping_address.html)
: The customer’s shipping address is displayed only  if:

- The **Report 
 Type** is **Detail**.
- A default shipping  address is defined for the customer.

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Default  Shipping Address]({{site.mc_chm}}/creating-a-customer/the-customer-profile-addresses/shipping_address_step.html)


**Contact Address**
: Select this check box to include the customer’s  contact address in the report.
: ![]({{site.rpt_baseurl}}/img/lens.gif) [Contact  Address]({{site.mc_chm}}/customer-details/addresses/contact_address.html)
: The customer’s contact address is displayed only  if the following conditions are met:

- The report **** type is **Detail**.
- A default contact  address is defined for the customer.

: ![]({{site.rpt_baseurl}}/img/lens.gif) [Default  Contact Address]({{site.mc_chm}}/creating-a-customer/the-customer-profile-addresses/contact_address_step.html)


{:.see_also}
See also
: [Customer List]({{site.rpt_baseurl}}/everest-reports/masters/customer_list.html)
