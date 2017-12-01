---
title: The Stock Transfer Profile
---

# The Stock Transfer Profile


The **Stock Transfer**  profile can be used to transfer stock within a single location and across  locations.


The Stock Transfer Profile for a Single Location Transfer


The **Stock Transfer**  profile (path: **Inventory** >  **Inventory Adjustment** > **Stock Transfer** > **Options**  > **New**) allows you to transfer  items from one stock area to another.


{:.note}
Stocks can be transferred from one area to  another of the same type only.


**![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) (Document Notes)**
: Click ![wh_notes_icon.gif]({{site.wm_baseurl}}/img/wh_notes_icon.gif) to attach notes to the document.  You will see the **Document** **Notes** dialog box where you can enter  any relevant information.
: Notes can be attached to keep track of important  messages or information pertaining to the document.


{:.example}
**You can attach a note giving details of the  requisition for the stock transfer.**
: The document note does not get printed with the  document. It is used primarily for communication between users within  the company.


**Document #**
: When you save a document, the system automatically  generates the document number.
: The document number is the next number in sequence  for inventory adjustment documents for the login location/sub-location.  This sequence number is specified in the Location profile (path: **File** > **Setup**  > **Preferences** > **Accounting**  > **Locations/Sub-Location** >  **Inventory** tab > **Inventory 
 Adjustment #** field).


{:.note}
Stock transfer document numbers are listed  in the **ST #** column in the **Stock Transfers** browser.


**Document Date**
: The login  date is automatically displayed in this field when you create the document.  You cannot change this date.


**From Bin**
: Specify the stock bin from which the items are transferred.


**To Bin**
: Specify the stock bin to which the items are transferred.
: **From Bin**  and **To Bin** fields are not displayed,  once you save the document.


{:.note}
From Bin and To Bin cannot be the same.
: ![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Document  Information]({{site.wm_baseurl}}/misc/document_information_stck_trsr.html)


Grid Information


**Line Number**
: This column displays the line number of the Item  Details Grid.


**Item Code**
: Specify the code of the item for which you want  to make stock transfers. Start typing characters in the Item Code field  to initiate the SmartSearch functionality. All inventoried items are listed  for selection. You can make a stock transfer for multiple items in the  same document. Once you save the document, you cannot modify this field.  This field is mandatory.


**Description**
: This field displays the item description. You cannot  modify this field.


**Type**
: This field displays the inventory type of the item.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Item Information]({{site.wm_baseurl}}/misc/item_information_stck_trsfr.html)


**UM**
: This column displays the stock measure for the item.  You cannot modify the unit of measure.


**From Invt Acnt**
: This field displays the Inventory Control Account  from where the stock is selected.


{:.note}
The Inventory Control Account defined in the  Posting Group assigned to the line item is considered first. If no Inventory  Control Account is defined for the item, the control account defined for  the category to which the line item belongs is used. If the Inventory  Control Account is not defined for either the item or the category, the  Inventory Control Account of the stock area’s location from where the  item is transferred is taken into consideration.


If the line item in a stock transfer document  is transferred from several stock areas pertaining to different locations  with different inventory control accounts the **From 
 Invt Acnt** column for this line item will be blank unless the user  overrides it.


The user may override the Inventory control  account by selecting one control account in the From Inventory account  column before the document is saved. However, there will be multiple rows  for such line item with multiple inventory control accounts in the journal.


**Cost**
: In the case of non-serialized items, this field  displays the average cost of the item. In the case of serialized items,  it displays the weighted average of the actual cost of the serial numbers  transferred. Average cost is the average cost of the item in the stock  unit of measure.


**To Bin**
: Select the stock bin to which you want to transfer  the items. This column will default to the Put Away bin defined for the  Requesting Location of the Stock Transfer document. This default can be  overridden to transfer the inventory to an alternative stock bin.


{:.note}
Sometimes the From Bin that you select may  be the same as the Put Away bin defined for the line item. In such an  instance, the system returns the To Bin field with a blank value to prevent  the occurrence of an overlap.


**To Invt Acnt**
: The Inventory Control Account defined in the Posting  Group assigned to the line item is considered first. If no Inventory Control  Account is defined for the item, the control account defined for the category  to which the line item belongs is used. If the Inventory Control Account  is not defined for either the item or the category, the Inventory Control  Account of the stock area’s location to where the item is transferred  is taken into consideration.


{:.note}
If a Posting Group with an Inventory control  account has been assigned to either the **Item**  profile or **Category** profile the  **From Invt Acnt** and the **To 
 Invt Acnt** inventory control accounts will be similar.


Irrespective of how the inventory control  account has been resolved, you can edit the **From 
 Invt Acnt** or the **To Invt Acnt**  inventory control accounts to any other account of the type Inventory  Control Account. However, a message appears warning the user of the possible  mismatch between the financial and inventory reports.


**Quantity**
: Enter the quantity of items to be transferred. This  column displays the total quantity of the items available for transfer  from a particular stock bin. The quantity is shown in the stock measure.  The quantity defaults to 1 with the decimal accuracy of the measure. With  the appropriate security rights, you can increase the quantity decimal  accuracy up to 6.


{:.example}
**Your default purchase measure is KG and the  KG decimal accuracy is 2. The quantity is shown as 1.00, but you can enter  1.123 or 1.12345.**
: You will have to attach the serial numbers of the  item for which the stock transfer is carried out, if the item selected  is serialized or auto-serialized.


{:.steps}
To attach serial number of the item, do the following:

- From the **Stock Transfer** profile, select **Options &gt; Attach Serial #**. You will  see the **Retrieve Serial Numbers**  dialog box.
- Specify the  serial number of the item you want to transfer.
- Click **Apply**.



If the item selected is non-serialized, you will have to enter the quantity  to be adjusted. This quantity cannot exceed the total quantity available  in the stock.


![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Calculation  of Stock Transfer Amounts]({{site.wm_baseurl}}/inv-adj/stk-trans/stock-transfer-details/calculation_of_stock_transfer_amounts_new.html)


**Amount**
: The total value of the quantity transferred in a  line is displayed in this field. It is in the decimal accuracy defined  in the currency profile. The value of the stock transferred is the average  cost multiplied by the quantity transferred. For serialized items, the  last cost of the item is displayed.


**![Lens.gif]({{site.wm_baseurl}}/img/lens.gif) [Quantity  and Cost Information]({{site.wm_baseurl}}/misc/quantity_and_cost_information_stck_trsr_prfle_details.html)**


The Stock Transfer Profile for Stock Transfer across Locations


The Stock Transfer profile (path: **Inventory**  > **Inventory Adjustments** >  **Stock Transfer** > **Options**  > **New Request** > **In 
 New Window**) allows you to transfer items from one stock area to  another, while specifying the particular location to and from which you  wish to transfer stock. This feature is particularly suitable for transferring  stock across locations.


The profile for stock transfer across locations is similar  to the single location stock transfer profile. Additionally, it has the  following field:


**Requested Quantity (in the Grid)**
: This column gives you the quantity of item requested  and allows you to commit a number of quantities against this requested  quantity in the Quantity column.


The **Stock Transfer**  profile shows the status of the stock transfer during the three stages.


The three stages of stock transfer for a company with multiple  locations are:

- Stock Transfer  - Request

: While you are defining the parameters for the stock  transfer, the profile shows the status Stock Transfer - Request. It continues  to be in Request stage till you commit the stock in the **Quantity**  column.
: ![]({{site.wm_baseurl}}/img/stock_transfer_request_stage_wm.gif)
: Figure: Stock Transfer Profile - Request  Stage
: When you commit / specify the quantity of stock  in the **Quantity** column in the  **Stock Transfer - Request** stage  and save the document, it automatically changes to In-Transit stage.

- Stock  Transfer - In-Transit

: During the Stock Transfer - In-Transit stage, the  stock in the **Quantity** column is  moved from the From Stock Bin temporarily to the In-transit bin specified  (**Locations** **Profile**  > **Stock** **Transfer**  > **Inventory Adjustment** >  **Stock Transfer Transit State** field).
: ![]({{site.wm_baseurl}}/img/stock_transfer_in_transit_stage_wm.gif)
: Figure: Stock Transfer Profile - In Transit  Stage

- Stock  Transfer - Completed

: Select  **Options**  > **Process** > **Completed**  from the Stock Transfer profile in In-Transit stage to complete the stock  transfer. During the Stock Transfer - Completed stage, the item is moved  from the **In-Transit** bin to the  **To Bin** specified in the profile.
: ![]({{site.wm_baseurl}}/img/stock_transfer_completed_stage_wm.gif)
: Figure - Stock Transfer Profile - Completed  Stage
: This completes the stock transfer process.


Since the **Amount**  column reflects the total amount of the transferred stock, it varies for  the three stages of  Stock  Transfer.
: **Request**  - The amount is the total amount of the requested quantity.
: **In-Transit**  - The amount is the total amount of the committed quantity or stock being  transferred.
: **Completed**  - The amount is the total amount of the stock that is transferred only.


{:.see_also}
See also
: [Details  Tab]({{site.wm_baseurl}}/misc/details_tab_stck_trsr_profile_steps.html)
: [Custom Fields Tab]({{site.wm_baseurl}}/misc/custom_fields_tab_stck_trnsfr_profile_steps.html)
: [Multimedia  Tab]({{site.wm_baseurl}}/misc/multimedia_tab_stck_trsr_profile_steps.html)
: [Transactions  Tab (Accounting Entries]({{site.wm_baseurl}}/misc/accounting_entries_tab_stck_trnsr_profiel_steps.html))
: [History  Tab (Transactions)]({{site.wm_baseurl}}/misc/transaction_history_tab_stck_trsr_profile_steps.html)
: [Status  bar Information]({{site.wm_baseurl}}/misc/status_bar_information_stck_trsr_doc_steps.html)
: [Print  a Stock Transfer Document]({{site.wm_baseurl}}/misc/printing_stock_transfer_documents.html)
: [Editing  Accounts in Inventory Adjustment Documents]({{site.wm_baseurl}}/misc/editing_accounts_in_inventory_adjustment_documents.html)
