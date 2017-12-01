---
title: The Cash Register Profile - Gift Receipt Tab
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.pos_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
![]({{site.pos_baseurl}}/img/cash_register_profile_gift_receipt_pos.gif)

# The Cash Register Profile - Gift Receipt Tab


You can format the gift receipt with images, messages, and  information inserted in tags using a preference setting.


{:.example}
A company would like its gift receipts for  the holiday season to be formatted with the picture of  holly  and a message that says "Happy Holidays!".  The  company would also like to insert the reference date. You can set your  preference settings for formatting gift receipts.


{:.steps}
To add a logo and a message to the gift receipt,  do the following:

- Select **File**  > **Setup** > **Miscellaneous**  > **Cash Register**. The **Cash Register** browser opens.



**[Figure: Cash Register Profile - Gift  Receipt Tab](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>**

- Select the cash  register for which you wish to format the gift receipts.
- Select **Edit**  > **In New Window**. The **Cash Register** profile opens.
- Select the **Gift Receipt** tab.
- Press the **Enter** key on the![]({{site.pos_baseurl}}/img/image_button_gift_receipt_pos.gif) button  (or click the button) to attach a logo bitmap. The logo's dimensions can  be a maximum of 3.0 inches x 1.0 inches.
- Write your message  in the **Message** box at the end  of gift receipt box.
- Select **Options**  > **Tags** to specify the tags  for inserting information for the gift receipt. You can access the **Tags** option only if your cursor is placed  in the Messages box.
- Press **Ctrl+Alt+S** or click the **Save and 
 Close** button.

: ![]({{site.pos_baseurl}}/img/lens.gif)[Change  Gift Receipt Printing Type]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-si-profile/options/change_gift_receipt_printing_type_pos_option_pos.html)


The following tags can be specified for a gift receipt.


| Term | Definition | Details |
| CARD HOLDER | Card Holder Name | Prints the name of the card holder. |
| EXP | Expiry Date | Prints the date till when the gift receipt is valid. |
| AMOUNT | Amount | Prints the amount of the gift receipt. |
| REF NUMBER | Reference Number | Prints the reference number of the document. |
| REF DATE | Reference Date | Prints the reference date of the document. |
| APPROVAL | Approval | Prints the Approval code. |
| TYPE | Payment Method / Type | Prints the payment method. |
| METHOD Description | Payment Method | Prints the details of the payment method. |
| TODAY | System Date | Prints the system date on the day when the gift receipt  is printed. |



When you specify a logo, messages and tags in the **Gift 
 Receipt** tab of the **Cash Register**  profile, these appear in the gift receipts.


{:.see_also}
See also
: [The  Cash Register Profile]({{site.pos_baseurl}}/pos-setup/cash-registers/setup/profile/the_cash_register_profilepos_set_up.html)
