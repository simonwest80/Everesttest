---
title: Using Cash Registers in regular Sales Documents
---

# Using Cash Registers in regular Sales Documents


You can set up cash registers to use while making collections and refunds  on regular sales documents. Using cash registers enables user accountability  for collections and refunds.


{:.example}
If you want to  track the cashier responsible for non-POS collections from customers,  you can:

- Create a new  cash register.
- Associate the  cashier with the cash register.
- Specify this  cash register as **User Based** in  your Document Flow Control preferences.


The cash register to be used on invoicing documents is specified in  the [**Documents** dialog box]({{site.bp_chm}}/flow-ctrl/ctrl/opt/misc/miscellaneous_document_payments_step_by_step_business_process_in_everest.html) (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Miscellaneous &gt; Document payments** tab  > **Registers** section).


**Cash register to use while making collection/refund  on regular sales document**
: This field allows you to select the preference for  using cash registers to account for collections and refunds against non-Point  of Sale sales documents. The options selected affect cash register selection  in **Receipt**, **Refund**  and **Collection** dialog boxes.


{:.example}
If you attach a cash register to a sales invoice,  any amount collected on that invoice will get updated in the cash register.


| Option | Description |
| **None** | Does not select any cash register for the document amount. The **Cash Register** field in the **Receipt**,  **Refund** and **Collection**  dialog boxes is disabled. |
| **User-based** | The **Cash Register** field in the  **Receipt**, **Refund**  and **Collection** dialog boxes uses  the register that is set up in the **User**  profile for the logged in user. |
| Default | The **Cash Register** field in the  **Receipt**, **Refund**  and **Collection** dialog boxes uses  the register that is set up in the **Default <br/> Cash Register** option in your document default preferences. |
| Other | The **Cash Register** field in the  **Receipt**, **Refund**  and **Collection** dialog boxes allows  you to select from the available cash registers. |



{:.note}
The cash registers, which are available and displayed in the drop-down,  are based on the following rules:

- If the logged in user is assigned a cash register,  then that cash register will be available for selection in the drop-down.
- If the logged in user is not assigned any cash  registers, then the list of cash registers attached to the user’s location/sub-location  and all cash registers that are not assigned to any location/sub-location  will be displayed.
- If the user is not assigned to any location/sub-location  then the list of cash registers available for the login location/sub-location  and all other cash registers that are not assigned to any location/sub-location  will be displayed.


**Default Cash Register**
: This field allows you to define the default cash  register to account for collections and refunds from the non-Point of  Sale sales documents.
: If you select the option **Default**  from the **Cash register to use while making 
 collection/refund on regular sales document** field and define a  cash register, it is automatically used to transfer payments on invoicing  documents.


{:.example}
You select **Default**  in the **Cash register to use while making 
 collection/refund on regular sales document** option, define “Cash  Register 1” in the **Default Cash Register**  field and create a sales order on which you receive a deposit from your  customer, the deposit is automatically associated with Cash Register 1.
