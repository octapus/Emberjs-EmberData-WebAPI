App.HistoricalsController = App.ColumnSorterController.extend
  columns: (-> [
    Em.Object.create(column: 'time')
    Em.Object.create(column: 'actionCode')
    Em.Object.create(column: 'resultCode')
    Em.Object.create(column: 'user')
    Em.Object.create(column: 'message')
  ]).property()