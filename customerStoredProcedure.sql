CREATE PROCEDURE dbo.customer
     
AS



    SELECT
    dbo.customers.CustomerId, 
    dbo.customers.Country, 
    dbo.customers.[BirthDate ], 
    dbo.customers.Email, 
    dbo.customers.HouseNo, 
    dbo.customers.Kebele, 
    dbo.customers.MobileNo, 
    dbo.customers.Region, 
    dbo.customers.Zone, 
    dbo.customers.Wereda, 
    dbo.customers.FirstName, 
dbo.customers.MiddleName,
dbo.customers.LastName,
dbo.customers.Sex,


    dbo.Nationality.description as country_description,
    dbo.Regions.description as region_description,
    dbo.Zones.description as zone_description,
    dbo.Woredas.description as wereda_description,
    dbo.Kebeles.description as kebele_description

FROM
 dbo.customers
  LEFT JOIN dbo.Nationality ON dbo.customers.Country = dbo.Nationality.code
  LEFT JOIN dbo.Regions ON dbo.customers.Region = dbo.Regions.code
   LEFT JOIN dbo.Zones ON dbo.customers.Zone = dbo.Zones.code
    LEFT JOIN dbo.Woredas ON dbo.customers.Wereda = dbo.Woredas.code
    LEFT JOIN dbo.Kebeles ON dbo.customers.Kebele = dbo.Kebeles.code;
RETURN 0 

exec customer;