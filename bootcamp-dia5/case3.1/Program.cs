




List<Visitante> visitantes = new List<Visitante>();
int proximoId = 1;

	int opcao = -1;

	do {
	Console.WriteLine("1 - Cadastrar visitante:");
	Console.WriteLine("2 - Listar visitante cadastrado:");
	Console.WriteLine("3 - Buscar visitante pelo nome:");
	Console.WriteLine("4 - Registrar saída do visitante:");
	Console.WriteLine("5 - Listar primeira visita do visitante");
	Console.WriteLine("0 - Sair");
	Console.WriteLine("Opção: ");


	try 
	{
	
		opcao = int.Parse(Console.ReadLine());

		
		switch (opcao) 
		{	
			case 1:
			CadastrarVisitante();
			break;
			case 2: 
			ListarVisitantes();
			case 3:
			BuscarPorNome();
			break;
			case 4:
			RegistrarSaida();
			break;
			case 5:
			ListarPrimeiraVisita();
			break;
			case 0:
			Console.WriteLine("Sistema encerrado");
		default:
			Console.WriteLine("Opção Inválida.");
			break;
			
		}
	
	}
		catch (Exception ex)
		{
			Console.WriteLine("Erro") + ex.Message;
			opcao = -1;
		}
	
	} while (opcao != 0);


	static void CadastrarVisitante() 
	{
		try 
		{
			Visitante v = new Visitante();

			
			v.Id = proximoId++;
			Console.WriteLine("Nome: ");
			v.Nome = Console.ReadLine();
			
			Console.WriteLine("Documento: ");
			v.Documento = Console.ReadLine();

			Console.WriteLine("Primeira visita? (s/n): ")
			v.EhPrimeiraVez = Console.ReadLine().ToLower() == "s";

			v.HorarioChegada = DateTime.Now;

			visitantes.Add(v);
			Console.WriteLine("Visitante cadastrado!");

			}
		
		catch 
		{
			Console.WriteLine("Erro ao cadastrar visitante.");
		}

	}

        static void ListarVisitantes()
	{ 

		for (int i = 0; i < visitantes.Count - 1; i++) 
		{

			for (int j = i + 1; j < visitantes.Count; j++) 
			{
				if (visitantes[i].Id > visitantes[j].Id) 
				{
					Visitante temp = visitantes[i];
					visitantes[i] = visitantes[j];
					visitantes = temp;
				}

			}
		}


	for (int i = 0; i < visitantes.Count; i++) 
	{
		Console.WriteLine(
		$"ID: {visitantes[i].Id} | " +
		$"Nome: {visitantes[i].Nome} | " +
		$"Chegada: {visitantes[i].HorarioChegada} | +
		$"Saída: {visitantes[i].HorarioSaida}"

		);
	}

	}
	//Count retorna o numero de elementos da lista visitantes
	static void BuscarPorNome() 
	{
		Console.WriteLine("Digite o nome: ");
		string nome = Console.Readline().ToLower();

		bool encontrado = false;

		for (int i = 0; i < visitantes.Count; i++) 
		{
			if (visitantes[i].Nome.ToLower().Contains(nome)) 
			{
				Console.WriteLine($"ID: {visitantes[i].Id} | Nome: {visitantes[i].Nome}");
				encontrado = true;

			}
		}


		if (!encontrado)

		{
			Console.WriteLine("Visitante não encontrado");
		}


	}

		static void RegistrarSaida()
	{

		try 
		{
			Conole.WriteLine("Digite o ID do visitante:");
			int id = int.Parse(Console.ReadLine());

			bool encontrado = false;

		for (int i = 0; i = visitantes.Count; i++) 
			{
				if (visitantes[i].Id == id) 
				{
					visitantes[i].HorarioSaida = DateTime.Now;
					Console.WriteLine("Saída registrada.");
					encontrado = true;
					break;
				}
			}

			if (!encontrado) 
			{
				Console.WriteLine("Visitante não encontrado.");
			}

		}	
		catch	
		{
			Console.WriteLine("Erro ao registrar a saída");
		}

	}

	
	static void ListarPrimeiraVisita()
	{
		bool existe = false;

		for (int i = 0; i < visitantes.Count; i++) 
		{
			if(visitantes[i].EhPrimeiraVez)
			{
				Console.WriteLine($"ID: {visitantes[i].Id} | Nome: {visitantes[i].Nome}");
				existe = true;
			}
		}

		if (!existe)

		{
			Console.WriteLine("Nenhum visitante em primeira visita.");
		}
	}
