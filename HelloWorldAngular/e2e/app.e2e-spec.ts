import { HelloWorldAngularPage } from './app.po';

describe('hello-world-angular App', () => {
  let page: HelloWorldAngularPage;

  beforeEach(() => {
    page = new HelloWorldAngularPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
