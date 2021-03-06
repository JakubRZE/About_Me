import { IEventDetail } from './../../interface/IEventDetail';
import { TimelineService } from './../../shared/timeline.service';
import { Component, OnInit, Input, OnChanges } from '@angular/core';


@Component({
  selector: 'app-timeline-event',
  templateUrl: './timeline-event.component.html',
  styleUrls: ['./timeline-event.component.css']
})
export class TimelineEventComponent {

  timelineEvents: { id: number, title: string, description: string, img: string }[] = [
    {
      "id": 1,
      "title": "WorkSample event.",
      "description": "Once upon a time.. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      "img": "https://www.fujifilm.com/products/digital_cameras/x/fujifilm_x_t1/sample_images/img/index/ff_x_t1_001.JPG"
    },
    {
      "id": 1,
      "title": "WorkSample event.",
      "description": "Once upon a time.. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      "img": "https://www.fujifilm.com/products/digital_cameras/x/fujifilm_x_t1/sample_images/img/index/ff_x_t1_001.JPG"
    },
    {
      "id": 1,
      "title": "WorkSample event.",
      "description": "Once upon a time.. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      "img": "https://www.fujifilm.com/products/digital_cameras/x/fujifilm_x_t1/sample_images/img/index/ff_x_t1_001.JPG"
    },
    {
      "id": 1,
      "title": "WorkSample event.",
      "description": "Once upon a time.. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
      "img": "https://www.fujifilm.com/products/digital_cameras/x/fujifilm_x_t1/sample_images/img/index/ff_x_t1_001.JPG"
    }
  ];

  private _id: number;
  @Input('id') 
  set categoryId(id: number) {
    this._id = id;
    if(this._id != null) {
      this.loadEvents(this._id);
    }
  }

  events: IEventDetail[] = [];
  defaultUrl:string = 'http://wallpapersite.com/images/wallpapers/rock-climbing-2560x1440-adventure-minimal-4k-993.jpg';
  errorMessage = '';

  constructor(private timelineService: TimelineService) { }

loadEvents(categoryId: number): void {
    this.timelineService.getEventsByCategoryId(categoryId).subscribe({
      next: events => this.events = events,
      error: err => this.errorMessage = err
    });
  }

}
