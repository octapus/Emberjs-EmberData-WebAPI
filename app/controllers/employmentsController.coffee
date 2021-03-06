App.EmploymentsController = App.ColumnSorterController.extend
  needs: [
    'debtor'
    'employment'
  ]
  columns: (-> [
    Em.Object.create(column: 'name')
    Em.Object.create(column: 'status')
    Em.Object.create(column: 'source')
    Em.Object.create(column: 'phone')
    Em.Object.create(column: 'title')
    Em.Object.create(column: 'hireDate')
  ]).property()

  actions:
    create: ->
      transaction = @get('store').transaction()
      @transitionToRoute 'employment', transaction.createRecord(App.Employment, 'debtor': @get('controllers.debtor').content, 'debtorId': @get('controllers.debtor').content.id)

    delete: (item) ->
      item.deleteRecord()
      @get('store').commit()