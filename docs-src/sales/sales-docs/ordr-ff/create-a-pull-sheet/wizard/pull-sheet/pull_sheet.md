---
title: Pull Sheet
---

# Pull Sheet


The **Pull Sheet** window **** displays a list of the pick tickets that are generated. One pull  sheet is created for all the pick tickets generated. **Everest** automatically generates the pull sheet number. The pick ticket(s)  and the pull sheet are created simultaneously.


The **Pull Sheet** window can be  sorted by any column in the browser. This window allows you to specify  the quantity actually picked for shipping. You can change the stock bin  from where the quantity has to be selected. However, you can only select  from the bins that were part of the selection made on the **Stock 
 Bin Selection** page.


**Quantities  can be entered in this window in the following ways:**

- Specifying  the quantity in the **Quantity Picked** column.  The quantity picked is shown in the measure selected for the item in the  sales order.
- Scanning the  items picked using a bar code scanner / the Commit Inventory option.



**![]({{site.sp_baseurl}}/img/note.gif) The quantity  picked cannot exceed the quantity to be picked. The stock can be picked  only from the stock bins specified in the [**Stock Bin Selection** section]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/stock-bin-selection/document_criteria_-_stock_area_selection_pick_ticket_wizard.html) of the  wizard.**


**Entering the Quantity Picked**


You can enter the quantity to be picked for the following items:

- [Serialized  Items]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pull-sheet/serialized_items_entering_qty_pull_sheet_browser.html)
- [Auto-serialized  Items and Non Serialized Items]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pull-sheet/auto_serialized_non_serialized_and_non_inventoried_items.html)



**![]({{site.sp_baseurl}}/img/hint.gif)If you  do not want to enter the quantity to be picked at this stage and try to  close the **Pull Sheet** browser,  **Everest** asks if you want to close  the status of the pull sheet. Select **No**  to keep the status of the pull sheet open. You can enter the quantity  to be picked at a later stage.**


![]({{site.sp_baseurl}}/img/steps.gif)After entering the quantity picked, do the  following:

- Click **Options** > **Commit 
 Picked Quantities**. The picked quantity is committed on the sales  order and the **Committed** column  is updated.


- You can then  convert the sales order to an invoice by selecting the **Convert 
 to Invoice** option (path: **Pull 
 Sheet** browser > **Options**  > **Convert to Invoice**).



![]({{site.sp_baseurl}}/img/hint.gif) You  can also process the sales order to an invoice using the **Process 
 &gt; Invoice** option from the **Sales 
 Order** profile.


![]({{site.sp_baseurl}}/img/lens.gif) [Convert to Invoice]({{site.sp_baseurl}}/misc/convert_to_invoice.html)

- Click **Continue** in the **Pull 
 Sheet** browser. You will see the [**Conclusion**]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/conclusion/conclusion_pick_ticket_wizard.html) section of the **Pull Sheet Wizard**.



{:.see_also}
See also
: [Pull Sheet Options]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pull-sheet/pull_sheet_options.html)
: [The Pull Sheet  Wizard]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/the_pull_sheet_wizard.html)
