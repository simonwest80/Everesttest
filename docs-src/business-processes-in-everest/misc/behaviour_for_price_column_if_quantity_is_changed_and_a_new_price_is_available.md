---
title: Behavior for price column if quoted/ordered quantity is changed and a new price is available
---

# Behavior for price column if quoted/ordered quantity is changed and  a new price is available


**Everest** allows you  to define how should the price alter when the quoted/ordered quantity  is changed and new price is available.


{:.example}
A company orders a pack of 100 CD-ROMs at  a price of $75. It later changes the order to 10 packs of 1000 CD-ROMs.  The vendor gives a special discount price of $700 instead of $750. Various  options are available as shown below to apply pricing in such an instance.


The price applicable to an item is calculated after considering all  pricing schemes when you retrieve the item into the sales document. If  the quantity of an item is changed and thus another price becomes applicable  to the item, the price may be changed automatically or **Everest**  may prompt you depending on the option selected in this field. **Everest**  provides you with the following options:


| **Option** | **Description** |
| Do not change | Price on the document will not be updated even if there  is a difference between the item price on the document and the new price  that becomes applicable. |
| Auto change | The price on the document will automatically be updated  as per the new price that becomes applicable. By default, this will be  selected. |
| Prompt before change | Prompts you when there is a price change. |
| Auto-change only if new price is lower | The document price will automatically be updated only  if the new price is lower. If the new price is higher, the existing line  item price on the document is retained. |
| Auto-change only if new price is higher | The document price will automatically be updated only  if the new line item price is higher. If the new price is lower, the existing  line item price on the document is retained. |
| Auto-change if new price is lower, Prompt if new price is higher | Prompts for the change in price only when the new price  is higher than the price on the document. Otherwise it will automatically  update the document price. |
| Auto-change if new price is higher, Prompt if new price is lower | Prompts for the change in price only when the new price  is lower than the price on the document. Otherwise it will automatically  update the document price. |
| Do not change if new price is higher, Prompt if new price is lower | Prompts for the change in price only when the new price  is lower than the price on the document. Otherwise the document price  will not be updated. |
| Do not change if new price is lower, Prompt if new price is higher | Prompts for the change in price only when the new price  is higher than the price on the document. Otherwise the document price  will not be updated. |



{:.note}
This option is applicable only if the quoted or ordered quantity is  changed in a sales document. It is not applicable when a sales order is  converted to a sales invoice and the shipped quantity is altered, and  when there is a change in the ordered quantity for a partially shipped  sales document.


{:.see_also}
See also
: [The  Documents Dialog Box - Pricing/Discounts]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/disc/flow_control_documents_dialog_box_pricing_discounts_tab_bp.html)
: [Setting  up Flow Control Options]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
