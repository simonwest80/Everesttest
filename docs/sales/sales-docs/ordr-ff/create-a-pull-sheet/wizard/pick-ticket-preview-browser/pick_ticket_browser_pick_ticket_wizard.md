---
title: Pick Ticket (Preview) Browser
---

# Pick Ticket (Preview) Browser


The **Pick Ticket (Preview)**  browser in the Pull Sheet Wizard gives you a preview of the pick tickets  that will be created for the pull sheet. You can view this browser only  while creating a pull sheet in the wizard. This is different from the  **Pick Tickets** browser (path: **Inventory** > **Pick****Tickets**) that lists all the pick  tickets in the system and can be accessed without opening the wizard.


Based on the parameters set in the previous sections of the  wizard, the items displayed in the **Pick 
 Ticket Preview** browser are sorted according to their sales order  numbers. The header that contains the details of each order displays whether  the customer pertaining to the order is on credit hold. If the effective  balance of the customer is above credit limit, the amount by which the  credit limit is exceeded is also displayed on the header.


![]({{site.sp_baseurl}}/img/example.gif) If  you specify the **FIFO** method in  the **Sales Order Priority** section,  the sales orders created earliest are displayed first in this browser.


![]({{site.sp_baseurl}}/img/pick_ticket_browser_sal.gif)


**Figure: Pick Ticket Browser**


Use the **Pick Ticket Browser**  to select the items and their quantities that have to be included in the  pick ticket. Uncommitted line items that can be filled will be selected  by default.  Based  on the option selected on the **Line Item**  section of the Pull Sheet Wizard, manually committed items are either  checked or unchecked by default.


{:.note}
The **Pick Ticket Browser** does not include 'non-inventoried' items since you cannot maintain  stock of such items.


The information and options in the **Pick 
 Ticket Browser** are categorized under the following:

- [Quantity  Columns in the **Pick Ticket Browser**]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pick-ticket-preview-browser/quantity_columns_in_the_pick_ticket_browser.html)
- [Record  Colors in the **Pick Ticket Browser**]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pick-ticket-preview-browser/record_colors_in_the_pick_ticket_browser.html)
- [Options  in the **Pick Ticket Browser**]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pick-ticket-preview-browser/options_in_the_pick_ticket_browser.html)



Click **Create Pull Sheet** from  the **Pick Ticket Browser**. You will  see the **Pull 
 Sheet** window.


{:.note}
- If you exit the  **Pull Sheet Wizard** at this stage,  pick tickets will not be created.
- If any of the item  quantities are not in stock, **Everest**  does not create a pull sheet when you click the **Create 
 Pull Sheet** button in the **Pick 
 Ticket Preview** browser and displays a warning message.
- Non-inventoried  items are not included in pick tickets unless the **Include 
 on Pick Ticket** column is selected for the line item in a sales  order. This option can be selected by default by selecting the **Include 
 on Pick Ticket** option on the **Inventory**  tab of the Item profile of the non-inventoried item.


{:.see_also}
See also
: [The Pull Sheet  Wizard]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/the_pull_sheet_wizard.html)
