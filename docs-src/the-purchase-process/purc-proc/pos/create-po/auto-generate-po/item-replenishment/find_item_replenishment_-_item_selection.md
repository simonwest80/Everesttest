---
title: Automated Purchases - Item Selection
---

# Automated Purchases - Item Selection


Use the **Automated Purchases**  – **Item Selection** tab to indicate  which item or items should be included in the **Item 
 Replenishment** browser list.


![]({{site.pp_baseurl}}/img/lens.gif) [Item  Replenishment Browser]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/item_replenishment_browser_find_items_dialog_box.html)


**Purchase Items with Inventory Supply Below**
: Select the items to display for purchase with inventory  supply below the following values:

- **Planned 
 Quantity** – Select this option to display items whose inventory  supply is less than the selected option in the **Planned 
 Quantity – Replenish inventory to** field on the **Replenishment**  tab. Other filter conditions must also be satisfied.
- **Reorder 
 Point** – Select this option to display items whose inventory supply  is less than the reorder point. This excludes items above the reorder  point. Other filter conditions must also be satisfied. This option is  selected by default.
- **Minimum 
 Quantity** – Select this option to display items whose inventory  supply is less than the minimum quantity. This excludes items above the  minimum quantity. Other filter conditions must also be satisfied.

: You can use this option to exclude items above the  reorder point or minimum quantity during item replenishment.
: The inventory supply, also know as current supply,  is defined by the following formula where SO = Sales Order and PO = Purchase  Order:
: Inventory Supply (Current Supply) = Total Stock  – Open SO + Open PO


**Item Type**
: Select the type of item: Regular, Assembly, or Matrix  Items.


**Inventoried Type**
: Select the type of inventory: Inventoried, Serialized,  or Auto serialized. By default, all types are included.
: For the following parameters, click the ![]({{site.pp_baseurl}}/img/pur_look_up_button.gif) button to the right of the field to display the appropriate  browser. Make a single selection in the browser or use the **Shift**  or **Ctrl** keys to make multiple  selections. Click **OK** in the browser.  In the selection window, clear the check boxes of any items that should  not be included. Click **OK** in the  selection window. If you made multiple selections for a field, “Multiple”  is displayed in that field.


**Item Code**
: Select the item code of the item to be replenished.  You can select multiple item codes. If you want to include all items in  the filter that satisfy the other filter conditions, leave this field  blank.


**Category**
: Select the category of the item. You can select  more than one category. If you want to include all item categories in  the filter that satisfy the other filter conditions, leave this field  blank.


**Brand**
: Select the brand of the item. You can select more  than one brand. If you want to include all brands in the filter that satisfy  the other filter conditions, leave this field blank.


**Manufacturer**
: Select the manufacturer of the item. You can select  more than one item. If you want to include all manufacturers in the filter  that satisfy the other filter conditions, leave this field blank.


**Vendor**
: Select any or all of the vendors listed in the selection  window based on your selection in the **Vendor****Selection Method** field on the  **Replenishment** tab. Vendors not  associated with any items do not appear in this window. The **Vendor**  field is disabled if you selected **Vendor 
 with lowest standard cost** in the **Vendor 
 Selection Method** field.
: If you selected **Associated 
 Vendor** in the **Vendor Selection 
 Method** field, you can only select one associated vendor in this  field. If the **Vendor** field is  left blank, only items that have no replenishment details will be shown.


The result of the parameters set in this dialog box appears  in **Item 
 Replenishment** browser. All filter conditions that you set must  be satisfied for an item to be listed.


{:.see_also}
See also
: [Automated  Purchases Dialog Box]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/automated_purchases_-_item_replenishment.html)
: [Automated  Purchases - Replenishment tab]({{site.pp_baseurl}}/purc-proc/pos/create-po/auto-generate-po/item-replenishment/find_item_replenishment_-_replenishment_tab.html)
