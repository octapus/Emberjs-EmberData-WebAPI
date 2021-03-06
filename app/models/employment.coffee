App.Employment = DS.Model.extend
  association:        DS.attr 'number'
  name:               DS.attr 'string'
  monthlyNetIncome:   DS.attr 'number'
  position:           DS.attr 'string'
  hireDate:           DS.attr 'isodate'
  phone:              DS.attr 'string'
  website:            DS.attr 'string'
  status:             DS.attr 'number'
  source:             DS.attr 'number'
  jobTitle:           DS.attr 'string'
  terminationDate:    DS.attr 'isodate'
  yearlyIncome:       DS.attr 'number'
  monthlyGrossIncome: DS.attr 'number'

  country:            DS.attr 'number'
  address1:           DS.attr 'string'
  address2:           DS.attr 'string'
  address3:           DS.attr 'string'
  city:               DS.attr 'string'
  state:              DS.attr 'string'
  zip:                DS.attr 'string'
  county:             DS.attr 'string'
  debtorId:           DS.attr 'number'

  debtor:             DS.belongsTo 'App.Debtor'