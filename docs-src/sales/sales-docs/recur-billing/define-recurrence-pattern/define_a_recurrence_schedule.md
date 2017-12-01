---
title: Define a Recurrence Schedule
---

# Define a Recurrence Schedule


The recurrence schedule identifies the following:

- The time period  for which the sales orders should be created.



![]({{site.sp_baseurl}}/img/example.gif) A  newspaper subscription for a year.

- The start and  end date for the period.



![]({{site.sp_baseurl}}/img/example.gif) In  the above example, the subscription runs from January 1, 2009 to December  31, 2009.

- The frequency  of billing (whether it is weekly, monthly etc.).



**![]({{site.sp_baseurl}}/img/example.gif) In  the same example, if the frequency of billing is weekly, 52 sales orders  are created.**

- Date of the  invoice **** - Whether the date on  the invoice should be the date of the sales order or the login  date when the sales order is converted to an invoice.



**![]({{site.sp_baseurl}}/img/example.gif) If  a recurring sales order is created on 1/4/2009 and converted on 5/4/2009,  the date of invoice can be either the sales order date (1/4/2009) or the  date on which it was invoiced (5/4/2009).**

- Credit card  payment information **** - Whether  full payment is received in advance.



The recurrence schedule can be defined before the order is saved and  even before items are included in the document. If the sales order is  not yet saved when you select the **Recurrence 
 Pattern** option,  it  is saved before you can define the recurrence pattern.


{:.note}
When recurring sales orders are created, a recurring  document ID is assigned to each set of recurring documents in addition  to the assigned document number. **Everest**  automatically generates this recurring document ID. A separate series  is created for recurring sales orders and purchase orders. You can view  the recurring document ID number in the **Recurring 
 doc. ID** column of the **Sales Orders** browser.


{:.steps}
To define a recurrence schedule, do the following:

- From the **Sales Order** profile, select **Options** > **Recurrence Pattern**.  You will see the [**Recurrence Pattern** dialog box]({{site.sp_baseurl}}/sales-docs/recur-billing/define-recurrence-pattern/the_recurrence_pattern_dialog_box.html).
- Enter the details  and click **OK**.
- If you select  the **Full Credit Card Payment** check  box, the **Payment for Recurring Document** dialog box is displayed.
- Specify the  details and click **OK**. **Everest**  informs you that the document ID that pertains to the set of sales orders  has been created.



{:.see_also}
See also
: [Modifying  Recurring Sales Order Information]({{site.sp_baseurl}}/sales-docs/recur-billing/recur-so-proc/modifying_recurring_sales_order_information.html)
: [Change Recurrence  Pattern]({{site.sp_baseurl}}/sales-docs/recur-billing/recur-so-proc/change_recurrence_pattern.html)
: [Recurring  Sales Documents]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/recurring_sales_documents_in_everest.html)
