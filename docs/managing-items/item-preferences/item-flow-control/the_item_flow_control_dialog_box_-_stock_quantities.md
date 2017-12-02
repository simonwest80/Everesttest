---
title: The Item Flow Control Dialog Box - Stock Quantities
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.mi_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
| Type of Order | Options | Effects |
| Sales Orders | No effect | The Stock Quantity is not affected by the quantities on sales orders |
| Ordered Quantity Subtracted | The ordered quantity on sales orders is subtracted from the total quantity |
| Committed Quantity Subtracted | The committed quantity on sales orders is subtracted from the total  quantity |
| Debit Orders | No effect | The Stock Quantity is not affected by the quantities on debit orders |
| Requested Quantity Subtracted | The requested quantity on debit orders is subtracted from the total  quantity |
| Committed Quantity Subtracted | The committed quantity on debit orders is subtracted from the total  quantity |
| Purchase Orders | No effect | The Stock Quantity is not affected by the quantities on purchase  orders |
| Ordered Quantity Added | The ordered quantity on purchase  orders  is added to the total quantity |
| Committed Quantity Added | The committed quantity on purchase orders is added to the total quantity |
| Credit Orders | No effect | The Stock Quantity is not affected by the quantities on credit orders |
| Requested Quantity Added | The requested quantity on purchase  orders  is added to the total quantity |
| Committed Quantity Added | The committed quantity on purchase orders is added to the total quantity |

# The Item Flow Control Dialog Box - Stock Quantities


Use this tab to configure stock quantities as per your requirements.  You can define the components to be used to calculate the stock that is  free to be sold. Stock is displayed in the **Items**  and **Item Stock Status** browsers  based on this configuration.


Stock Quantity 1


**Show Stock Quantity 1 in browsers and profiles**
: Select this check box if you want the stock configured  for Stock Quantity 1 to be displayed in the browsers and profiles.


{:.note}
All the other fields in this section are enabled  only when you select this check box.


**Stock Quantity Name**
: Specify a name for the stock quantity being configured  using up to 20 alphabetic characters. When you create a new company, by  default, the name displayed in this field is Normal Stock. This field  is enabled when you select the Show Stock Quantity 1 in browsers and profiles  check box. This is a mandatory field.


**Include Quantities From**
: Select the bins from which you want to include the  stock for Stock Quantity 1. The following options are available:

- Normal Type  Bins Only
- All Stock Bins



{:.note}
**Normal type bins only** is the  default value for this field.


**Effects of order quantities on stock quantity  1**
: Use the fields in this section to decide to what  extent you want the Sales Order, Credit Order, Purchase Order and Debit  Order to affect the stock quantity displayed in the browsers and profiles.


The drop-down options available for the four types of orders and the  effects of selecting each option are elucidated in the [table](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>.


Stock Quantity 2
: Use this section to configure another stock quantity  to be displayed in the **Item** and **Item Stock Status** browsers. The fields  in this section are similar to the fields in the Stock Quantity 1 section  of this dialog box.


{:.see_also}
See also
: [Items  Dialog Box]({{site.mi_baseurl}}/item-preferences/item-flow-control/the_flow_control_setup_dialog_box_wm.html)
