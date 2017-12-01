---
title: The Exchange Rates Profile
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# The Exchange Rates Profile


Use the **Exchange Rate** profile  to enter the buy and sell rates for a currency.


**Entry Number**
: The entry number is a unique auto generated number  used as an identifier within **Everest**.


**Currency Code**
: Specify the code of the currency for which you are  defining the exchange rate. The currency code identifies the foreign currency  for which the rate is being entered. This is a mandatory field. Once saved  this field cannot be modified.


**Description**
: The description that has been defined for the selected  currency is displayed in this field. You cannot edit the description.


**Time**
: Specify the date and time of quoting the exchange  rate. **Everest** defaults to the  current system date and time in this field. This is a mandatory field.  Once saved, this field cannot be modified.


**Buy Rate**
: Specify the buy rate in terms of the [quote quantity](javascript:BSSCPopup('{{site.sc_baseurl}}/misc/quote_quantity_2.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>.  The buy rate is the rate at which you buy the currency to settle debts  in foreign currency.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Buy  and Sell Rates]({{site.sc_baseurl}}/options/multicurrency/exchange-rates/exchange-rate-details/buy_and_sell_rates.html)


**Sell Rate**
: Specify the sell rate in terms of the [quote quantity](javascript:BSSCPopup('{{site.sc_baseurl}}/misc/quote_quantity_2.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>.  The selling rate is the rate that you will realize when the currency is  sold. Inflows in this currency are generally accounted at this rate.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Buy  and Sell Rates]({{site.sc_baseurl}}/options/multicurrency/exchange-rates/exchange-rate-details/buy_and_sell_rates.html)


{:.note}
It is mandatory to enter at least one rate:  the buy or sell rate. When one of the rates is entered, the other is automatically  updated with the same. You can modify this rate as required.


**Source Currency**
: This field displays the base currency in which your  accounting records are maintained, provided the quote type is base to  foreign. It cannot be edited.


**Destination Currency**
: This field displays the currency based on the quote  type specified in the **Currency**  profile. This field cannot be edited.


{:.see_also}
See also
: [Defining exchange  rates]({{site.sc_baseurl}}/options/multicurrency/exchange-rates/set-up-exchange-rates/defining_exchange_rates.html)
