import { ServeurModule } from './serveur.module';

describe('ServeurModule', () => {
  let serveurModule: ServeurModule;

  beforeEach(() => {
    serveurModule = new ServeurModule();
  });

  it('should create an instance', () => {
    expect(serveurModule).toBeTruthy();
  });
});
