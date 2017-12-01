---
title: Pull Sheet Browser Options
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
Select this option, after highlighting the required item, to view the  details of the serial number attached to the items in the [**Serial #**]({{site.sp_baseurl}}/sales-docs/docs-profile/options/items/serial_browser.html) browser. This option is  not enabled after the picked quantities are confirmed and if the pull  sheet is 'closed'.

Select this option to pick a serialized item. This option is enabled  only for serialized and auto-serialized items. The Attach Serial # option  is NOT enabled if the pull sheet is 'closed'.


![]({{site.sp_baseurl}}/img/lens.gif) [Attach  Serialized Items - One by One]({{site.sp_baseurl}}/misc/one_by_one_entering_serialized_items_pull_sheet_browser.html)

Select this option to pick a range of serial numbers for serialized  and auto-serialized items. The **Attach 
 Serial # (Range)** option is NOT enabled if the pull sheet is 'closed'.


**![]({{site.sp_baseurl}}/img/lens.gif) [Attach  Serialized Items - Range]({{site.sp_baseurl}}/misc/range_entering_serialized_items_pull_sheet_browser.html)**

Select this option if the serial numbers should be attached only to  the currently highlighted order. This option is useful if you do not want  to attach the serial numbers (manually entered/scanned) to other line  items in the **Pull Sheet** browser  with the same item code at one stretch.

Use this toggle option to select and deselect all the items for picking.

If you select this option, the **Quantity 
 Picked** column automatically displays the quantities that can be  picked. This is the quantity to be picked for all non-serialized items  not tracked for lots and auto-serialized items, excluding the quantity  already committed in sales orders.


If any of the item quantities are not in stock, **Everest**  displays the following warning message:


"There is a difference between  the quantity to be picked and the actual quantity in stock for non serialized  items not tracked for lots, and some of the sales orders could not be  committed to the extent of the difference quantity at the time of commit".


Select **OK** to automatically pick  the item quantities that are in stock. The item quantities not in stock  will not be committed and the **Quantity 
 Picked** column will show zero quantities.

This option is enabled after items have been picked using either the  **Auto pick** option or entering quantities  in the **Quantity Picked** column.  When you select this option, the picked quantities get committed to sales  orders.


If all the items in the Pull Sheet are not picked, and you select the  **Commit Picked Quantities** option,  **Everest** prompts you to confirm  whether you want to commit the picked quantities only. Select **Yes**  to commit the picked quantities.


After all the items (serialized and non-serialized) are committed in  the Pull sheet, you can click the “Continue” button to close the Pull  Sheet. **Everest** displays a message  saying that all the items in the Pull Sheet are committed, and the Pull  Sheet will be closed. Select **Yes**  to close the Pull sheet or **No**  to keep it open.


{:.note}
The Pull sheet cannot be kept open if all the items are committed. You  can manually close the Pull sheet by using the **Close 
 Pull Sheet** option even without committing all the items.


If all the items on the Pull sheet are **not**  committed, and the “Continue” button is clicked, **Everest**  informs you of the same and asks if you want to close the pull sheet.  If you select **Yes**, **Everest**  warns you that once the Pull Sheet is closed, you cannot commit the quantities.  If you select **Yes** again, **Everest** asks you whether you want to  de-link the sales orders that are not fully committed. Select **Yes**  to de-link the sales orders or **No** if  you do not want to de-link.

Select the [Convert  to Invoice]({{site.sp_baseurl}}/misc/convert_to_invoice.html) option to create sales invoice(s)  for the selected items. This option is NOT enabled until the picked quantities  are confirmed using the **Commit Picked 
 Quantities** option.

Select a sales order and click this option to delink the sales order  from the pull sheet. This will delink the sales order even if part of  the quantity is committed. The uncommitted quantity can be committed on  the sales order from the **Sales Orders**  browser.


{:.note}
You cannot delink a sales order without either committing  the picked quantity or unassigning it. If you assign quantity in the **Quantity Picked** column and try to delink  the sales order, you are prompted that it is imperative to commit or uncommit  quantities prior to delinking the sales orders.


This option is available only when one or more line items on a sales  order are attached to an open pull sheet, irrespective of whether the  item are picked or not.

Select this option to view the all the sales invoices created for the  selected sales order.

Use this toggle option to include or exclude items that have been shipped  in the **Pull Sheet** browser. Note  that the check box in the **Shipped**  column is checked if all the quantities for the line item are shipped.

The Pull Sheet wizard allows you to filter sales orders with credit  card authorizations as fully paid. The **Batch 
 Credit Card Processing &gt; Prior Authorization** option allows you  to capture funds for those sales orders. When you select this option,  you will see the [Batch  Payment Process - Prior Authorizations browser]({{site.acc_chm}}/customer-receipts-and-refunds/batch-payment-processing/batch_credit_card_process_use_prior_authorization_browser.html) displaying only pre-authorized  transactions for all the sales orders that are part of the Pull Sheet.

Select this option to mark the pull sheet as closed. A closed pull sheet  can merely be printed or processed to an invoice. You cannot pick items  for closed pull sheets. When all the required items have been committed  on a pull sheet, the pull sheet status automatically changes to closed.  When a pull sheet is marked as closed, the **Picked**  column in the **Sales Order** profile  is deselected.  This option is NOT enabled if the pull sheet status is 'closed'.


If all the items on the Pull sheet are **not**  committed, and you choose this option, **Everest**  informs you of the same and asks if you want to close the pull sheet.  If you select **Yes**, **Everest**  warns you that once the Pull Sheet is closed, you cannot commit the quantities.  If you select **Yes** again, **Everest** asks you whether you want to  delink the sales orders that are not fully committed. Select **Yes**  or **No** as per your requirement.

Use this option to enter additional or special information in the **Pull Sheet Notes** dialog box. Enter the  notes and select **Options &gt; Save** to  save the notes.

Select this option to print the pull sheet. When you select this option,  the **Print 
 Setup** dialog box **** is  displayed.

Highlight the required pick tickets and select this option to print  the pick ticket(s)  associated with the pull sheet. You will see the **Printing 
 Preferences** dialog box. You can print the report by clicking the  **Print** icon.


The item description displayed on the pick ticket is the modified item  description from the sales document.

Select this option to view the stock details of the highlighted item.  You will see the **Item 
 Stock Status** browser.

# Pull Sheet Browser Options


The following options are available in the **Pull Sheet** browser **** (path: **Pull Sheet** browser **** > **Options**):

- [**Show Serial #**](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
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
- [Delink  SO](javascript:kadovTextPopup(this)){:id="a9"}<script type="text/javascript" language="JavaScript1.2"><!--
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
: [Pull Sheet Browser]({{site.sp_baseurl}}/misc/pull_sheet_browser.html)
