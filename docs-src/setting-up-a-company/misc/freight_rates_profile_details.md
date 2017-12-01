---
title: The Rates Profile - Details
---

# The Rates Profile - Details


Use this tab to specify the freight rate details based on any one of  the following: Category/Item, Document Weight or Document Total.


{:.note}
You can select only one option to calculate  the freight charges.


Based on Category/Item


Select this option to specify the freight rate based on either a category  or an item.


**Category**
: Select the item category for which this freight  rate is applicable. The category name is displayed in the adjacent field.


**Item**
: Select the item code for which the freight rate  is applicable. The item name is displayed in the adjacent field.


{:.note}
You can specify either a category or an item, not both.


**Measurement Unit**
: Select the unit of measurement for the category  or item. Freight is calculated based on the measurement unit specified  here for the item or category.
: Freight is calculated per unit of item if you specify  the measurement unit as PIU  (Per Item Unit).
: If an item or category has the Per Item Unit value  for the **Measurement Unit** field,  **Everest** multiplies the freight  rate for the item/category with the quantity of the item ordered/shipped  on sales documents.
: The computation of freight depends on the **Quantity Entry Method** selected in the  **Purchases** tab of the **Item**  profile: Fractional or Decimal.


{:.example}
Fractional method for item XYZ


Sales Measure - 6 pieces per pack


Freight Rate - $5 per item unit


If 10 packs of the item XYZ are shipped on  a sales document, the freight amount would be 10 X 6 X $5 = $300.


Decimal method for item ABC


Sales Measure - KG


Freight Rate - $5 per item unit


If 10.50 KG of item ABC are shipped on a sales  document, the freight amount would be 10.50  X  $5 = $52.50
: The above quantity refers to the item’s lowest unit  (EA for example)  and NOT the item’s Sales measure. If an item is sold in Dozen (Sale Measure),  Per Item Unit refers to each piece (unit) of the item and not one dozen  units of the item (Sales Measure).


**Minimum Freight**
: Enter a minimum amount for freight charges. This  amount is displayed if the calculated freight charge is less than the  amount entered here.


**Rate Per Unit**
: Enter a value in this field. This value is multiplied  with the unit specified in the **Measurement****Unit** field for calculating the  freight charges for the item.
: To allow free shipping for an item/category, the  **Minimum Freight** and the **Rate Per Unit** fields can be left blank.


{:.example}
If you had fixed the measurement unit as grams  and the rate per unit as $1, it implies that $1 is charged for every gram.


Based on Document Weight


Select this option to specify the freight rate based on the document  weight.


**Document Weight From**
: Specify the starting weight range of the document.


**Document Weight To**
: Specify the ending weight range of the document.


**Rate Per Unit**
: Enter a value in this field. This value is multiplied  with the unit specified in the **Measurement 
 Unit** field for calculating the freight charges for the item.


{:.example}
If you have fixed the document weight from  1500 grams to 5000 grams and the rate per unit as $1, it implies that  $1 is charged for every gram within the specified weight range.


**Freight Rate Type**
: Select the type of rate you want to apply for freight  calculation. You can select **Per Unit**, **Flat** or **Per 
 Hundred Weight**.
: **Per Unit -** Define  the freight rate per unit of item weight in the document.


{:.example}
If you specify $1 as the rate per gram, for  a document weight ranging from 20 grams to 120 grams, the freight for  a document of 80 grams will be $80.
: **Flat -** Define  a flat rate of freight for documents whose weight falls in the range specified.


{:.example}
If you specify a flat rate of $100 for a document  weight ranging from 20 grams to 120 grams, the freight for a document  of 80 grams will be $100.
: **Per Hundred Weight 
 -** Define the freight rate per hundred units of item weight in the  document.


{:.example}
If you specify $50 as the rate per hundred  weight for a document weight ranging from 1 lb to 1000 lbs, the freight  for a document of 11.0231 lbs will be divided by 100 and multiplied by  50. The freight charged will be $5.51.


**Measurement Unit**
: Select the unit of measurement for which the freight  is applicable. The items in the sales document are converted to this unit  and accordingly, freight charge is calculated.


Based on Document Total


Select this option to compute the freight based on the total amount  of the document.


**Document Total From**
: Specify the starting amount for the range of the  document total. This value must be greater than ‘Zero’.


**Document Total To**
: Specify the ending amount for the range of the document  total. This value must be greater than ‘Zero’.


**Freight**
: Enter the amount of freight you want to charge on  the document, for the specified document total range. To allow free shipping,  the **Freight** field can be left  blank.


{:.see_also}
See also
: [Freight Rates  Profile]({{site.sc_baseurl}}/options/everest-freight-estimator/rates/freight_rates_profile.html)
