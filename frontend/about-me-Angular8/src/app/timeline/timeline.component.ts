import { Component, OnInit } from '@angular/core';
import { TimelineService } from '../shared/timeline.service';
import { ICategory } from '../interface/ICategory';

@Component({
  selector: 'app-timeline',
  templateUrl: './timeline.component.html',
  styleUrls: ['./timeline.component.css']
})
export class TimelineComponent implements OnInit {

  timelineCategories: { id: number, title: string, description: string, img: string }[] = [
    {
      "id": 1,
      "title": "Work",
      "description": "A little bit about work I experienced so far.",
      "img": "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201810/online-3412473_1920.jpeg?meGHIUut1mybIL3pem8eWqk34osmW3Zi"
    },
    {
      "id": 2,
      "title": "Education",
      "description": "Something about my education path.",
      "img": "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201810/online-3412473_1920.jpeg?meGHIUut1mybIL3pem8eWqk34osmW3Zi"
    },
    {
      "id": 3,
      "title": "Programming",
      "description": "All my project I menaged to create so far.",
      "img": "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201810/online-3412473_1920.jpeg?meGHIUut1mybIL3pem8eWqk34osmW3Zi"
    },
    {
      "id": 4,
      "title": "After Hours",
      "description": "My hobbies and life after hours.",
      "img": "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201810/online-3412473_1920.jpeg?meGHIUut1mybIL3pem8eWqk34osmW3Zi"
    }
  ];
  defaultUrl: string = "https://c.pxhere.com/photos/0f/1e/collaborate_collaboration_creative_design_designer_group_groupware_hands-911060.jpg!d";

  errorMessage = '';
  categories: ICategory[] = [];
  categoryId: number;
  selectedCategory: ICategory;

  constructor(private timelineService: TimelineService) { }

  ngOnInit(): void {
    this.timelineService.getCategories().subscribe({
      next: categories => this.categories = categories,
      error: err => this.errorMessage = err
    });
  }

  onCategoryClicked(category: ICategory): void {
    this.selectedCategory = category; 
    this.categoryId = category.Id;
  }
}
