import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { baseUrl } from "../core/constants";
import { Frequency } from "./frequency.model";

@Injectable()
export class FrequencyService {
  constructor(
    @Inject(baseUrl) private _baseUrl:string,
    private _client: HttpClient
  ) { }

  public get(): Observable<Array<Frequency>> {
    return this._client.get<{ frequencies: Array<Frequency> }>(`${this._baseUrl}api/frequencies`)
      .pipe(
        map(x => x.frequencies)
      );
  }

  public getById(options: { frequencyId: number }): Observable<Frequency> {
    return this._client.get<{ frequency: Frequency }>(`${this._baseUrl}api/frequencies/${options.frequencyId}`)
      .pipe(
        map(x => x.frequency)
      );
  }

  public remove(options: { frequency: Frequency }): Observable<void> {
    return this._client.delete<void>(`${this._baseUrl}api/frequencies/${options.frequency.frequencyId}`);
  }

  public save(options: { frequency: Frequency }): Observable<{ frequencyId: number }> {
    return this._client.post<{ frequencyId: number }>(`${this._baseUrl}api/frequencies`, { frequency: options.frequency });
  }
}
