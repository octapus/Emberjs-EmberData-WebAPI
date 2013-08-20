App.Debtor = DS.Model.extend
  type:        				DS.attr 'string'
  title:       				DS.attr 'string'
  lastName:        	  DS.attr 'string'
  firstName:     			DS.attr 'string'
  middleName:         DS.attr 'string'
  suffix:  						DS.attr 'string'
  dob:								DS.attr 'date'
  ssn:								DS.attr 'string'
  martialStatus:			DS.attr 'string'
  email:							DS.attr 'string'
  emailValidity:			DS.attr 'number'
  optIn:							DS.attr 'string'
  contact:	          DS.attr 'string'

  country:            DS.attr 'number'
  address1:           DS.attr 'string'
  address2:           DS.attr 'string'
  address3:           DS.attr 'string'
  city:               DS.attr 'string'
  state:              DS.attr 'string'
  zip:                DS.attr 'string'
  county:             DS.attr 'string'
  
  dlIssuer:						DS.attr	'string'
  dlNumber:						DS.attr	'string'
  passport:						DS.attr	'string'
  pin:								DS.attr	'string'

  contacts: 					DS.hasMany 'App.Contact'
  persons:            DS.hasMany 'App.Person'
  employments:        DS.hasMany 'App.Employment'
  notes:              DS.hasMany 'App.Note'

  clientId:           DS.attr 'number'