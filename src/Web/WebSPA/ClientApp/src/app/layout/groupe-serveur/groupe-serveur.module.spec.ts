import { GroupeServeurModule } from './groupe-serveur.module';

describe('GroupeServeur.ServiceModule', () => {
  let groupeServeurServiceModule: GroupeServeurModule;

  beforeEach(() => {
    groupeServeurServiceModule = new GroupeServeurModule();
  });

  it('should create an instance', () => {
    expect(groupeServeurServiceModule).toBeTruthy();
  });
});
