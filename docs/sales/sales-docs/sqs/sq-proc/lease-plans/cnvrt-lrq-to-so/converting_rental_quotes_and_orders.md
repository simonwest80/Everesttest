---
title: Convert Rental Quotes and Orders
---

# Convert Rental Quotes and Orders


When a sales quote with a rental plan attached is converted to an order  and then to an invoice, the details of the plan attached are copied to  the sales order or invoice.


![]({{site.sp_baseurl}}/img/lens.gif) [Creating a Rental  Quote]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/create-lrq/creating_a_rental_quote.html)


{:.steps}
The following steps are involved in renting  an item:

- Create the  rental quote.
- Convert the  rental quote to a sales order.
- Select a stock  area that represents 'Items Out on Rent' in the **Assign 
 inventory from &gt; Sales Order** field of your **Workstation 
 Settings** dialog box **** (path:  **File &gt; Setup &gt; Preferences &gt; 
 Workstation Settings &gt; Stock Areas &gt; For Sales** tab).



{:.note}
You  have to create a stock area that represents 'Items out on Rent'  in the [**Stock Areas** profile]({{site.sc_chm}}/options/miscellaneous-set-up/stock-areas/stock-areas/stock_area_profile_general_tab.html).

- Attach the  items rented to the order.  The  rented items will be transferred to the selected stock area.
- For collecting  the amount of rent, create a new sales invoice.
- If the ownership  of the items is transferred to the customer at the end of the rental period,  convert the sales order created in the second step to an invoice.
- If the items  are returned to you and the rental agreement is terminated, detach the  items from the sales order created in the second step and close the order.



{:.see_also}
See also
: [Converting  Lease Quotes and Orders]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/cnvrt-lrq-to-so/converting_lease_quotes_and_orders.html)
