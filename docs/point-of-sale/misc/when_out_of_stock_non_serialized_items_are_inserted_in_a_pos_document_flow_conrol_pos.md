---
title: When out of stock non-serialized items are inserted in a POS document
---

# When out of stock non-serialized items are inserted in a POS document


**Everest** is equipped to handle  the following situations in POS:

- When the quantity  of a non-serialized item brought to the cash counter exceeds the quantity  available.
- When the item  belongs to a third party and is sold under an arrangement with the third  party.



In such cases, you can decide how to treat non-serialized items that  are out of stock. The following options are available:

- **None**  - This option does not allow you to either attach items from a different  stock area or to add quantity. The non-availability of stock is conveyed  through a message.
- **Adjust 
 Inventory -** This option brings up the **Quantity 
 Adjustment** and the **Attach Quantity**  dialog boxes that allow you to adjust inventory by adding quantity of  items to stock.

: ![]({{site.pos_baseurl}}/img/lens.gif) [Quantity  Adjustment dialog box]({{site.wm_chm}}/inv-adj/qty-adj/create-a-qty-adj-doc/the_quantity_adjustments_profile.html)

- **Force 
 Sale**
- If there is no stock,  this option allows the sales representative to enter non-serialized items  to a Point of Sale (sales invoice) document.
- If there is partial  stock, the **Force Sale Options**  dialog box appears when you enter non-serialized items in a Point of Sale  (sale invoice) document. You can reduce the quantity to match available  quantity, change the unavailable quantity to a force sale or add quantity.

: ![]({{site.pos_baseurl}}/img/lens.gif) [Force  Sales Options Dialog Box]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-si-profile/force-sale/excd-avl-qty/force-sale-item/flow-ctrl-prefs/options.html)


{:.see_also}
See also
: [Flow  Control Preferences]({{site.pos_baseurl}}/pos-setup/point-of-sale-preferences/flow_control_preferences_pos.html)
