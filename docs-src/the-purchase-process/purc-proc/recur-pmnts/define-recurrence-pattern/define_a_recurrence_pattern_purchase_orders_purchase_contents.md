---
title: Define a Recurrence Schedule
---

# Define a Recurrence Schedule


The recurrence schedule can be defined for a purchase order even before  items are included in the document.


To define a recurrence schedule, you must specify:

- The time period  for which the purchase orders should be created.



{:.example}
If you take a newspaper subscription for a  year, the period will be a year.

- The start and  end date for the period.



{:.example}
In the above example, if the subscription  runs from January 1, 2002 to December 31, 2002, the start and end dates  have to be entered.

- The frequency  of billing (whether it is weekly, monthly, etc.).



{:.example}
In the same example, if the frequency of billing  is weekly, then 52 purchase orders will be created.

- Whether the  date on the invoice should be the date of the purchase order or the login  date when the purchase order is converted to a invoice.
- Whether full  payment is made in advance.



{:.note}
When recurring purchase orders are created, a recurring  document ID is automatically assigned to each set of recurring documents  in addition to the assigned document number. A separate series is created  for recurring sales orders and purchase orders. You can view the recurring  document ID number in the **Recurring doc.ID** column of the **Purchase****Orders** browser.


![]({{site.pp_baseurl}}/img/steps.gif)To define a recurrence schedule, do the following:

- From the **Purchase** **Order**  profile, select **Options** > **Recurrence** **Pattern**.  You will see the [**Recurrence Pattern**]({{site.pp_baseurl}}/purc-proc/recur-pmnts/define-recurrence-pattern/the_recurrence_pattern_dialog_box_purchase_orders_contents.html) dialog box.
- Enter the **details** and click **OK**.
- If you select  the **Full** **credit****card** **payment**  check box, the **Payment** **for****Recurring** **Document**  dialog box is displayed.
- Specify the  details and click **OK**.
- **Everest**  displays the document ID of the purchase orders created.



{:.note}
You cannot change the recurrence pattern once it is  defined and the purchase orders are created.


{:.see_also}
See also
: [Modify  Recurring Purchase Order Information]({{site.pp_baseurl}}/purc-proc/recur-pmnts/upd-rec-po/modifying_recurring_purchase_order_information_recurrence_pattern_dialog_box_purhcase_orders.html)
: [Change  Recurrence Pattern]({{site.pp_baseurl}}/purc-proc/recur-pmnts/upd-rec-po/change_recurrence_pattern_recurrence_pattern_purhcase_orders.html)
: [Recurring  Purchase Documents]({{site.pp_baseurl}}/purc-proc/recur-pmnts/recurring_purchase_documents_purchase_contents.html)
