---
title: Registers
---

# Registers


**Cash register to use while making collection/refund  on regular sales document**
: Use this field to select the preference for using  cash registers to account for collections and refunds against non-Point  of Sale sales documents. The options selected affect cash register selection  in **Receipt**, **Refund**  and **Collection** dialog boxes.
: ![]({{site.bp_baseurl}}/img/example.gif)  If  you attach a cash register to a sales invoice, any amount collected on  that invoice will get updated in the cash register.
: The options available  are:


| **None** | Does not select any cash register for the document amount. The **Cash Register** field in the **Receipt**,  **Refund** and **Collection**  dialog boxes is disabled. |
| **User-based** | The **Cash Register** field in the  **Receipt**, **Refund**  and **Collection** dialog boxes uses  the register that is set up in the User profile for the logged in user. |
| Default | The **Cash Register** field in the  **Receipt**, **Refund**  and **Collection** dialog boxes uses  the register that is set up in the **Default <br/> Cash Register** option in the document default preferences. |
| Other | The **Cash Register** field in the  **Receipt**, **Refund**  and **Collection** dialog boxes allows  you to select from the available cash registers. |

: The cash registers which are available and displayed  in the drop-down list, are based on the following rules:

- If the logged in  user is assigned a cash register, that cash register will be available  for selection in the drop-down list.
- If the logged in  user is not assigned any cash registers, the list of cash registers attached  to the user’s location/sub-location and all cash registers that are not  assigned to any location/sub-location will be displayed.
- If the user is  not assigned to any location/sub-location, the list of cash registers  available for the login location/sub-location and all other cash registers  that are not assigned to any location/sub-location will be displayed.



**Default Cash Register**
: Use this field to define the default cash register  to account for collections and refunds from the non-Point Of Sale sales  documents.
: When you select the option **Default**  from the **Cash register to use while making 
 collection/refund on regular sales document** field, and define a  cash register in this option, it is automatically used to transfer payments  on invoicing documents.
: ![]({{site.bp_baseurl}}/img/example.gif)  You  select “Cash Register 1” as the default register in the **Cash 
 register to use while making collection/refund on regular sales document**  option and create a sales order on which you receive a deposit from your  customer, the deposit received is automatically associated with Cash Register  1.


{:.see_also}
See also
: [Document  Payments]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/misc/document_payments_business_process_contents.html)
: [Documents  Dialog Box - Miscellaneous]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html)
: [Setting  up Flow Control Options]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
