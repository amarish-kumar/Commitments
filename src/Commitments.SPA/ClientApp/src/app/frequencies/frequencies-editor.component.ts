import { Component, Input } from "@angular/core";
import { Subject, BehaviorSubject } from "rxjs";
import { FrequencyType } from "./frequency-type.model";
import { Frequency } from "./frequency.model";
import { ColDef } from "ag-grid";

@Component({
  templateUrl: "./frequencies-editor.component.html",
  styleUrls: ["./frequencies-editor.component.css"],
  selector: "app-frequencies-editor"
})
export class FrequenciesEditorComponent { 

  public onDestroy: Subject<void> = new Subject<void>();

  ngOnDestroy() {
    this.onDestroy.next();	
  }

  @Input()
  public frequencyTypes: Array<FrequencyType> = [];

  @Input()
  public frequencies$: BehaviorSubject<Array<Frequency>> = new BehaviorSubject([]);

  public handleFrequencySave($event) {
    this.frequencies$.next([...this.frequencies$.value,$event.frequency]);
  }

  public onGridReady(params) {
    params.api.sizeColumnsToFit();
  }

  public handleSaveClick() {
    console.log(this.frequencies$.value);
  }

  public remove(frequency) {
    var frequencies: any[] = [...this.frequencies$.value];
    var index = frequencies.findIndex(x => x.frequency == frequency.data.frequency && x.frequencyTypeId == frequency.data.frequencyTypeId);    
    frequencies.splice(index, 1);
    this.frequencies$.next(frequencies);
  }

  public columnDefs: Array<ColDef> = [
    {
      headerName: 'Frequency',
      field: 'frequency'
    },
    {
      headerName: 'Frequency Type',
      field: 'frequencyTypeId'
    },
    {      
      template: `<a>Remove</a>`,
      onCellClicked: frequency => this.remove(frequency)
    }
  ];
}
