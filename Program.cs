using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> genres = new List<string>()
        {
            "Sci-Fi",
            "Mystery",
            "Horror",
            "Adventure",
            "Drama",
            "Fantasy",
            "Romance",
            "Poetry",
            "Novel",
            "Comedy"
        };

        Console.WriteLine("Welcome to the Book Selector! Below are the list of genres:");

        for (int i = 0; i < genres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {genres[i]}");
        }

        Console.Write("Enter the chosen genre number here: ");
        int genreNumber = Convert.ToInt32(Console.ReadLine());

        if (genreNumber < 1 || genreNumber > genres.Count)
        {
            Console.WriteLine("Ulitin mo yan.");
            return;
        }

        string selectedGenre = genres[genreNumber - 1];

        switch (selectedGenre)
        {

            case "Sci-Fi":
                Console.WriteLine("Recommended Sci-Fi Titles:");
                Console.WriteLine("1. Ender's Game by Orson Scott Card");
                Console.WriteLine("2. The Hitchhiker's Guide to the Galaxy by Douglas Adams");
                Console.WriteLine("3. Dune by Frank Herbert");
                break;

            case "Mystery":
                Console.WriteLine("Recommended Mystery Titles:");
                Console.WriteLine("1. And Then There Were None by Agatha Christie");
                Console.WriteLine("2. Anatomy of a Murder by Robert Traver");
                Console.WriteLine("3. In Cold Blood by Truman Capote");
                break;

            case "Horror":
                Console.WriteLine("Recommended Horror Titles:");
                Console.WriteLine("1. Frankenstein by Mary Shelley ");
                Console.WriteLine("2. Salem's Lot by Stephen King");
                Console.WriteLine("3. We Have Always Lived in the Castle by Shirely Jackson");
                break;

            case "Adventure":
                Console.WriteLine("Recommended Adventure Titles:");
                Console.WriteLine("1. Gulliver's Travels. by Jonathan Swift");
                Console.WriteLine("2. Heart of Darkness. by Joseph Conrad");
                Console.WriteLine("3. Jurassic Park by Michael Crichton");
                break;

            case "Drama":
                Console.WriteLine("Recommended Drama Titles:");
                Console.WriteLine("1. Click by Kayla Miller");
                Console.WriteLine("2. Then She Was Gone by Lisa Jewell");
                Console.WriteLine("3. Where the Crawdads Sing by Delia Owens");
                break;

            case "Fantasy":
                Console.WriteLine("Recommended Fantasy Titles:");
                Console.WriteLine("1. Harry Potter by J.K. Rowling");
                Console.WriteLine("2. Everyday by David Levithan");
                Console.WriteLine("3. Ender's Game by Orson Scott Card");
                break;

            case "Romance":
                Console.WriteLine("Recommended Romance Titles:");
                Console.WriteLine("1. The Notebook by Nicholas Sparks");
                Console.WriteLine("2. Outlander by Diana Gabaldon");
                Console.WriteLine("3. Pride and Prejudice by Jane Austen");
                break;

            case "Poetry":
                Console.WriteLine("Recommended Poetry Titles:");
                Console.WriteLine("1. The Sun and Her SunFlowers by rupi kaur");
                Console.WriteLine("2. The Complete Poems of Emily Dickinson by Emily Dickinson");
                Console.WriteLine("3. Smoke and Mirrors by Neil Gaiman");
                break;

            case "Novel":
                Console.WriteLine("Recommended Novel Titles:");
                Console.WriteLine("1. You Know Me Well by Nina Lacour and Levithan");
                Console.WriteLine("2. Shadows in the Water by Inger Frimansson");
                Console.WriteLine("3. The Catcher in the Rye by J.D. Salinger");
                break;

            case "Comedy":
                Console.WriteLine("Recommended Comedy Titles:");
                Console.WriteLine("1. Such A Fun Age by Kiley Reid");
                Console.WriteLine("2. The Devil's Dictionary by Ambrose Bierce");
                Console.WriteLine("3. Me Talk Pretty One Day by David Sedaris");
                break;

            default:
                Console.WriteLine("Does not exist.");
                break;
        }

        Console.WriteLine("Enter chosen genre for booklist set synopsis:");
        string genre = Console.ReadLine();

        if (genre == "Science Fiction")
        {
            Console.WriteLine("Ender's Game by Orson Scott Card");
            Console.WriteLine("Tells the story of a young boy, Ender Wiggin, who is sent to a training academy named Battle School, located in orbit above the Earth, built to train people to become soldiers that will one day battle against a vast alien race called the Buggers.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("The Hitchhiker's Guide to the Galaxy by Douglas Adams");
            Console.WriteLine("Seconds before the Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy who, for the last fifteen years, has been posing  as an out-of-work actor.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Dune by Frank Herbert");
            Console.WriteLine("It tells the story of Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, who must travel to the most dangerous planet in the universe to ensure the future of his family and his people.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Mystery")
        {
            Console.WriteLine("And Then There Were None by Agatha Christie");
            Console.WriteLine("Europe teeters on the brink of war. Ten strangers are invited to Soldier Island, an isolated rock near the Devon coast. Cut off from the mainland, with their generous hosts Mr and Mrs U.N. Owen mysteriously absent, they are each accused of a terrible crime.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Anatomy of a Murder by Robert Traver");
            Console.WriteLine("The story becomes Biegler's as underdog in a tough contest against a high-powered prosecutorial team. Biegler must find a way to legally justify the act in such a way as to overcome the natural sympathies and consciences of the jury. It seems an insurmountable challenge—until Biegler begins to dig beneath the surface and uncovers startling facts have not yet come to light. The truth is far more complex than anyone imagined.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("In Cold Blood by Truman Capote");
            Console.WriteLine("The book tells the story of the murder of the Clutter family, consisting of Mr. and Mrs. Clutter and their two teenage children, Kenyon and Nancy (two older daughters were grown and out of the house), and the events that lead the killers to murder. ");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Horror")
        {
            Console.WriteLine("Frankenstein by Mary Shelley ");
            Console.WriteLine("Frankenstein tells the story of gifted scientist Victor Frankenstein who succeeds in giving life to a being of his own creation. However, this is not the perfect specimen he imagines that it will be, but rather a hideous creature who is rejected by Victor and mankind in general.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Salem's Lot by Stephen King");
            Console.WriteLine("Salem's Lot is the story of a small American town being overtaken by vampires, and a brave band of people who come together to fight an ancient evil. Events centre on Ben Mears, a moderately successful writer who has returned to Jerusalem's Lot in order to write a novel based on his early years.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("We Have Always Lived in the Castle by Shirely Jackson");
            Console.WriteLine("The narrator, Mary Katherine Blackwood (known as Merricat) introduces herself and reveals that all of her relatives are dead, except for her sister Constance. She then begins her story some time earlier, on the day she brought home the library books that still sit on her shelf, long overdue.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Adventure")
        {
            Console.WriteLine("Gulliver's Travels. by Jonathan Swift");
            Console.WriteLine("Lemuel Gulliver is a married English surgeon who wants to see the world. He takes a job on a ship and ends up shipwrecked in the land of Lilliput where he is captured by the miniscule Lilliputians and brought to the Lilliputian king.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Heart of Darkness. by Joseph Conrad");
            Console.WriteLine("Heart of Darkness centers around Marlow, an introspective sailor, and his journey up the Congo River to meet Kurtz, reputed to be an idealistic man of great abilities. Marlow takes a job as a riverboat captain with the Company, a Belgian concern organized to trade in the Congo.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Jurassic Park by Michael Crichton");
            Console.WriteLine(" A cautionary tale about genetic engineering, it presents the collapse of a zoological park showcasing genetically recreated dinosaurs to illustrate the mathematical concept of chaos theory and its real world implications.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Drama")
        {
            Console.WriteLine("Click by Kayla Miller");
            Console.WriteLine("A novel about a 6th grade girl who wants to do a talent show but she doesn't have a partner to do it with. She gets really down on herself because nobody will ask her to join their group for the talent show.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Then She Was Gone by Lisa Jewell");
            Console.WriteLine("When Ellie Mack goes missing, Laurel's life falls apart. Her marriage ends and she doesn't have a close relationship with her two remaining children or herself. However, when they find Ellie's partial remains, she says goodbye at the funeral but finds herself in a mystery instead of closure.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Where the Crawdads Sing by Delia Owens");
            Console.WriteLine("Where the Crawdads Sing is part bildungsroman and part crime drama, centered around Kya, a wild and unkempt girl. The book follows the ups and downs of her life. She lives a lonely life, but her story is a hopeful one as well. With a little help, she's able to survive and even learn to read.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Fantasy")
        {
            Console.WriteLine("Harry Potter by J.K. Rowling");
            Console.WriteLine("It is a story about Harry Potter, an orphan brought up by his aunt and uncle because his parents were killed when he was a baby. Harry is unloved by his uncle and aunt but everything changes when he is invited to join Hogwarts School of Witchcraft and Wizardry and he finds out he's a wizard.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Everyday by David Levithan");
            Console.WriteLine("“Every Day,” written by David Levithan, follows the unique story of A, a person who wakes up every day in a different body living a different life. A spends day after day inhabiting a different body and pretending to be the person without making any variations in their personality or life.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Ender's Game by Orson Scott Card");
            Console.WriteLine("This tells the story of a young boy, Ender Wiggin, who is sent to a training academy named Battle School, located in orbit above the Earth, built to train people to become soldiers that will one day battle against a vast alien race known as Buggers.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Romance")
        {
            Console.WriteLine("The Notebook by Nicholas Sparks");
            Console.WriteLine("The story centers on the relationship between Noah Calhoun and Allie Nelson. Spanning over five decades, their love endures an uncertain beginning, the onset and conclusion of World War II, the death of one child, and Allie's eventual diagnosis of Alzheimer's disease.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Outlander by Diana Gabaldon");
            Console.WriteLine("Outlander follows the story of Claire Randall, a married combat nurse from 1945 who is mysteriously swept back in time to 1743, where she is immediately thrown into an unknown world where her life is threatened.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Pride and Prejudice by Jane Austen");
            Console.WriteLine("Pride and Prejudice follows the turbulent relationship between Elizabeth Bennet, the daughter of a country gentleman, and Fitzwilliam Darcy, a rich aristocratic landowner. They must overcome the titular sins of pride and prejudice in order to fall in love and marry.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Poetry")
        {
            Console.WriteLine("The Sun and Her SunFlowers by rupi kaur");
            Console.WriteLine("To quote Rupi Kaur, “the sun and her flowers is a collection of poetry about grief, self-abandonment, honoring one's roots, love, and empowering oneself.” Just like milk and honey, this one too is divided into thematic chapters: wilting.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("The Complete Poems of Emily Dickinson by Emily Dickinson");
            Console.WriteLine("Dickinson’s poems use largely simple language, many off-rhymes, and unconventional punctuation to deal with a small set of themes that she returned to again and again. Death, grief, passion, faith, truth, and fame and success are the most prominent of these themes. Each time she revisits one of these threads, she comes at it differently, never allowing her interpretation of truth to become entrenched or oversimplified.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Smoke and Mirrors by Neil Gaiman");
            Console.WriteLine("An elderly widow finds the Holy Grail beneath an old fur coat. A stray cat fights and refights a terrible nightly battle to protect his unwary adoptive family from unimaginable evil. A young couple receives a wedding gift that reveals a chilling alternative history of their marriage. ");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Novel")
        {
            Console.WriteLine("You Know Me Well by Nina Lacour and Levithan");
            Console.WriteLine("Told in two points of view, YOU KNOW ME WELL is the story of Bay Area teens Mark and Kate, who've sat next to each other in calculus for an entire year but don't know each other until one fateful night when they both happen to be partying in San Francisco the week leading up to the annual Pride parade.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Shadows in the Water by Inger Frimansson");
            Console.WriteLine("The book is about a character named Justine Dalvik. years have passed since Justine killed Berit, a 40 something year old mother of two living in a small town near Stockholm. Her life has since then taken a calmer direction, she is in a new romantic relationship and the risk for being discovered should be over. However, the past threatens to catch up with her.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("The Catcher in the Rye by J.D. Salinger");
            Console.WriteLine("The Catcher in the Rye describes the adventures of well-off teenage boy Holden Caulfield on a weekend out alone in New York City, illuminating the struggles of young adults with existential questions of morality, identity, meaning, and connection.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else if (genre == "Comedy")
        {
            Console.WriteLine("Such A Fun Age by Kiley Reid");
            Console.WriteLine("This is about Emira, a 25-year-old black woman, who is working as a babysitter to raise Briar, a 3-year-old white girl. It's a story that examines modern racism by depicting the fallout after Emira is hassled and accused of being a kidnapper when she takes Briar to the supermarket.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("The Devil's Dictionary by Ambrose Bierce");
            Console.WriteLine("Known for criticizing society and common human practices, Bierce's The Devil's Dictionary takes a satirical approach in defining words related to religion, politics, society, and human behavior. Satire is defined as the use of ridicule and sarcasm to expose or denounce human folly.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Me Talk Pretty One Day by David Sedaris");
            Console.WriteLine("This story is a collection of essays about the everyday life of the author, David Sedaris. The book's first essays detail his upbringing in North Carolina. As a child, he lives with his father, mother, and sisters. The opening essay recounts the time he's forced to see a speech therapist in the fifth grade.");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("The synopsis for that book is not available.");
        }

        Console.WriteLine("Click '1' to exit the program");

        while (Console.ReadKey().Key != ConsoleKey.D1)
        {
            Console.WriteLine("Please click '1' to exit the program");
        }

        Console.WriteLine("Itigil na natin ito.");

    }
}

