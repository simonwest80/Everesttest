---
title: Pull Sheet Options
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
Select this option to scan items by Model No., Item Code, Item Alias  or Serial Number from the **Commit Inventory**  dialog box (path: **Options** >  **Commit Inventory** from the **Pull Sheets** window). You can set the  sequence of the order by which **Everest**  will retrieve the item by setting flow control preferences (path: **File** > **Setup** > **Preferences** > **Flow Control** > **Items**  > **Item Details** tab).


![]({{site.sp_baseurl}}/img/commit_inventory_psb_specific_location_sal.gif)


**Figure: Commit Inventory Dialog Box**


All inventoried, serialized and auto-serialized items can  be scanned. Every correct entry increases the quantity in the Committed  column of the sales order by the quantity in the **Qty**  field of the **Commit Inventory**  dialog box. The **Qty** field defaults  to 1, but with the appropriate security right, you can change the quantity  for regular items. Serial numbers always scan as 1 unit and the quantity  cannot be changed.


To prevent mistakes, this screen flashes a red signal and  sounds a beep for an invalid entry. An invalid scan message is indicated  both visually and audibly for the following reasons:

- Item does not exist
- Quantity exceeds  order quantity
- Item is not in  document list



![]({{site.sp_baseurl}}/img/incorrect_scan_sal.gif)


**Figure: Incorrect Scan Message**


**Stock bins from**
: Select the location of the item from the **Stock 
 bins from** drop-down list. If you select the Specific Location option,  the Location field is enabled.


**Location**
: Select the location from the Location drop-down  list when you select the Specific Location option.


Click the **History**  button to view the history of all scan attempts/actions.  This  screen can be useful for identifying when an invalid barcode was scanned  or a mistake was made. History will only display the scan history while  the commit inventory screen has been open.

Select this option to view the history of all the scan events for the  document. The **Item Scan History**  browser lists the following actions:

- Assigned
- Skipped
- Invalid Product
- Quantity exceeded

Select this option, after highlighting the required item, to view the  details of the serial number attached to the items in the [**Serial #**]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/serial_browser.html) browser. This option is  not enabled after the picked quantities are confirmed and if the pull  sheet is 'closed'.

Select this option to pick a serialized item. This option is enabled  only for serialized and auto-serialized items. The Attach Serial # option  is NOT enabled if the pull sheet is 'closed'.


![]({{site.sp_baseurl}}/img/lens.gif) [Attach  Serialized Items - One by One]({{site.sp_baseurl}}/misc/one_by_one_entering_serialized_items_pull_sheet_browser.html)

Select this option to pick a range of serial numbers for serialized  and auto-serialized items. The **Attach 
 Serial # (Range)** option is NOT enabled if the pull sheet is 'closed'.


**![]({{site.sp_baseurl}}/img/lens.gif) [Attach  Serialized Items - Range]({{site.sp_baseurl}}/misc/range_entering_serialized_items_pull_sheet_browser.html)**

Select this option if the serial numbers should be attached only to  the currently highlighted order. This option is useful if you do not want  to attach the serial numbers (manually entered/scanned) to other line  items in the **Pull Sheet** browser  with the same item code at one stretch.

Use this toggle option to select and deselect all the items for picking.

If you select this option, the **Quantity 
 Picked** column automatically displays the quantities that can be  picked. This is the quantity to be picked for all non-serialized items  and auto-serialized items, and lot tracked inventory items excluding the  quantity already committed in sales orders.


Select **OK** to automatically  pick the item quantities that are in stock. The item quantities not in  stock will not be committed and the **Quantity 
 Picked** column will show zero quantities.

This option is enabled after items have been picked using either the  **Auto Pick** option, or entering  quantities in the **Quantity Picked**  column either manually or by using the **Commit 
 Inventory** option (path: **Options**  > **Commit Inventory**). When you  select this option, the picked quantities are committed to sales orders.


If all the items in the Pull Sheet are not picked, and you select the  **Commit Picked Quantities** option,  **Everest** prompts you to confirm  whether you want to commit the picked quantities only. Select **Yes**  to commit the picked quantities.


After all the items (serialized and non-serialized) are committed in  the Pull sheet, you can click the “Continue” button to close the Pull  Sheet. **Everest** displays a message  saying that all the items in the Pull Sheet are committed, and the Pull  Sheet will be closed. Select **Yes**  to close the Pull sheet or **No**  to keep it open.


{:.note}
The Pull sheet cannot be kept open if all the items are committed. You  can manually close the Pull sheet by using the **Close 
 Pull Sheet** option even without committing all the items.


If all the items on the Pull sheet are **not**  committed, and the “Continue” button is clicked, **Everest**  informs you of the same and asks if you want to close the pull sheet.  If you select **Yes**, **Everest**  warns you that once the Pull Sheet is closed, you cannot commit the quantities.  If you select **Yes** again, **Everest** asks you whether you want to  de-link the sales orders that are not fully committed. Select **Yes**  to de-link the sales orders or **No** if  you do not want to de-link.

Select the [Convert  to Invoice]({{site.sp_baseurl}}/misc/convert_to_invoice.html) option to create sales invoice(s)  for the selected items. This option is NOT enabled until the picked quantities  are confirmed using the **Commit Picked 
 Quantities** option.

Select a sales order and click this option to remove the sales order  from the pull sheet. This will remove the sales order even if part of  the quantity is committed. The uncommitted quantity can be committed on  the sales order from the **Sales Orders**  browser.


{:.note}
You cannot remove a sales order without either committing  the picked quantity or unassigning it. If you assign quantity in the **Quantity Picked** column and try to remove  the sales order, you are prompted that it is imperative to commit or uncommit  quantities prior to removing the sales orders.


This option is available only when one or more line items on a sales  order are attached to an open pull sheet, irrespective of whether the  items are picked or not.

Select this option to view the all the sales invoices created for the  selected sales order.

Use this toggle option to include or exclude items that have been shipped  in the **Pull Sheet** browser. Note  that the check box in the **Shipped**  column is checked if all the quantities for the line item are shipped.

The Pull Sheet wizard allows you to filter sales orders with credit  card authorizations as fully paid. The **Batch 
 Credit Card Processing &gt; Prior Authorization** option allows you  to capture funds for those sales orders. When you select this option,  you will see the [Batch  Payment Process - Prior Authorizations browser]({{site.acc_chm}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_use_prior_authorization_browser.html) displaying only pre-authorized  transactions for all the sales orders that are part of the Pull Sheet.

Select this option to mark the pull sheet as closed. A closed pull sheet  can merely be printed or processed to an invoice. You cannot pick items  for closed pull sheets. When all the required items have been committed  on a pull sheet, the pull sheet status automatically changes to closed.  When a pull sheet is marked as closed, the **Picked**  column in the **Sales Order** profile  is deselected.  This option is NOT enabled if the pull sheet status is 'closed'.


If all the items on the Pull sheet are **not**  committed, and you choose this option, **Everest**  informs you of the same and asks if you want to close the pull sheet.  If you select **Yes**, **Everest**  warns you that once the Pull Sheet is closed, you cannot commit the quantities.  If you select **Yes** again, **Everest** asks you whether you want to  delink the sales orders that are not fully committed. Select **Yes**  or **No** as per your requirement.

Use this option to enter additional or special information in the **Pull Sheet Notes** dialog box. Enter the  notes and select **Options &gt; Save** to  save the notes.

Select this option to print the pull sheet. When you select this option,  the **Print 
 Setup** dialog box **** is  displayed.

From the Pull Sheet, you can use the **Print 
 Pick Tickets** option to print selected pick tickets to show where  items that need to be picked are located in your warehouse.  Details  on the pick ticket report are sorted based on the warehouse position of  the stock bin where the items exist.


To do this, on the Pull Sheet, highlight the required pick tickets and  select the **Print Pick Tickets**  option (**Options** > **Print 
 Pick Tickets**) to print the pick ticket(s) associated with the pull  sheet. Items display in the order of the warehouse position and you can  distinguish inventory that has been previously committed.


You will see the **Printing Preferences**  dialog box. You can print the report by clicking the **Print**  icon.


**Copies**
: Select the number of pick ticket copies to be printed.


**Display committed inventory details**
: Select this option to display picking details for  items that have been previously committed to the sales order. This is  the default selection.


The **Pick Ticket** report shows  the following fields of interest:


**Description**
: The **Description**  column of the Pick Ticket report will match the description of the item  entered in the sales order.  Inventory  details will be printed below the description if the “Display committed  inventory details”option is selected.  Examples  of inventory details that will be displayed include Lot numbers and Serial  Numbers (Manufacturer or Internal).


**Stock Bin**
: In the **Stock Bin**  column of the Pick Ticket report, an asterisk (\*) displays after the stock  bin of the line items that have already been partially or fully committed.

Select this option to view the stock details of the highlighted item.  You will see the **Item 
 Stock Status** browser.

# Pull Sheet Options


The following options are available in the **Pull Sheet** window **** (path: **Pull Sheet** window **** > **Options**):

- [Commit  Inventory](javascript:kadovTextPopup(this)){:id="a18"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a18');
//--></script>
- [Scan History](javascript:kadovTextPopup(this)){:id="a19"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a19');
//--></script>
- [Show  Serial #](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [**Attach Serial #**](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
- [**Attach Serial # (Range)**](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
- [**Attach Serial # within the order highlighted**](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
- [**Select All/Unselect 
 All**](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
- [**Auto pick**](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>
- [**Commit Picked Quantities**](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>
- [Convert  to Invoice](javascript:kadovTextPopup(this)){:id="a8"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a8');
//--></script>
- [Remove  SO](javascript:kadovTextPopup(this)){:id="a9"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a9');
//--></script>
- [View  Invoices Created](javascript:kadovTextPopup(this)){:id="a10"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a10');
//--></script>
- [Include/Exclude  Shipped Items](javascript:kadovTextPopup(this)){:id="a11"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a11');
//--></script>
- [Batch  Credit Card Processing > Prior Authorization](javascript:kadovTextPopup(this)){:id="a12"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a12');
//--></script>
- [Close  Pull Sheet](javascript:kadovTextPopup(this)){:id="a13"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a13');
//--></script>
- [Notes](javascript:kadovTextPopup(this)){:id="a14"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a14');
//--></script>
- [Print  Pull Sheet](javascript:kadovTextPopup(this)){:id="a15"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a15');
//--></script>
- [Print  Pick Tickets](javascript:kadovTextPopup(this)){:id="a16"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a16');
//--></script>
- [Item  Stock Status](javascript:kadovTextPopup(this)){:id="a17"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a17');
//--></script>



Options common to all browsers are also available in this browser.


![]({{site.sp_baseurl}}/img/lens.gif) [Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)


The following options are not available from the closed Pull Sheet:

- Show Serial Number
- Attach Serial Number
- Attach Serial Number  (Range)
- Serialize within  the order highlighted
- Auto Pick
- Commit Picked Quantities
- Close Pull Sheet



{:.see_also}
See also
: [Pull Sheet Browser]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pull-sheet/pull_sheet.html)
: [The Pull Sheet  Wizard]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/the_pull_sheet_wizard.html)
: [Pick  Ticket - Printing Preferences]({{site.sp_baseurl}}/sales-docs/ordr-ff/create-a-pull-sheet/wizard/pull-sheet/pick_ticket_printing_preferences_sal.html)
