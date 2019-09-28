import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TimelineComponent } from './timeline/timeline.component';
import { TimelineEventComponent } from './timeline/timeline-event/timeline-event.component';

@NgModule({
  declarations: [
    AppComponent,
    TimelineComponent,
    TimelineEventComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
